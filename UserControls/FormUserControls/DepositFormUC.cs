using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace HBorsWinApp
{
#if DEBUG
    public partial class DepositFormUC : NonGenericDepositFormUC
#else
    public partial class DepositFormUC :  CustomUserControl<Deposit>
#endif
    {
        public DepositFormUC(System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
        {
            view_mode = view_mode_;
            edit_id = id_;

            InitializeComponent();
        }

        private void DepositFormUC_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        protected override void LoadPage()
        {
            LoadAsynch();

            _ = new Fund().LoadAllToComboBox(fldFund);
            List<string> fund_key = new List<string>();
            fldFund.Combo_SelectedIndexChangedResult(fund_key);

            CustomCombo cbUnit = fldUnit.field as CustomCombo;
            cbUnit.lookup_action = (key) => TempUnits(key);
            bool first_load = true;
            fldFund.Combo_SelectedIndexChanged((s, e) =>
            _ = cbUnit.BindData(fund_key[0],
                () =>
                {
                    if (first_load)
                    {
                        LoadAfterAsyncEditData(() =>
                        {
                            fldUnit.SetValue(EntityToEditObject.unit_cost_id);
                        });
                        first_load = false;
                    }
                })
                );
            List<string> unit_key = new List<string>();
            fldUnit.Combo_SelectedIndexChangedResult(unit_key);


            CustomCombo cbAccount = fldAccount.field as CustomCombo;
            cbAccount.lookup_action = (key) =>
                {
                    var accounts = new List<KeyValuePair<string, string>>();
                    if (!string.IsNullOrWhiteSpace(key)) accounts = new Account().GetAccounts(long.Parse(key));
                    return Task.FromResult(accounts);
                };
            fldFund.Combo_SelectedIndexChanged((s, e) => _ = cbAccount.BindData(fund_key[0]));

            fldUnit.Combo_SelectedIndexChanged(async (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(unit_key[0]))
                {
                    var unit = await new UnitCost().Get<UnitCost>(unit_key[0]);
                    fldIssueCost.Text_SetText(unit.Model?.issue_cost?.ToString());
                }
                else
                {
                    fldIssueCost.Text_SetText("");
                }

            });

            List<decimal?> count = new List<decimal?>();
            fldCount.Numeric_ValueChangedResult(count);
            List<string> issue_cost = new List<string>();
            fldIssueCost.Text_ValueChangedResult(issue_cost);

            fldAmount.driven_action = (key) =>
            {
                return Task.FromResult(key);
            };
            fldCount.Numeric_ValueChanged((s, e) =>
            {
                AmountDriveAcion(count, issue_cost);
            });
            fldIssueCost.Text_ValueChanged((s, e) =>
            {
                AmountDriveAcion(count, issue_cost);
            });


            buyerGridLastRow.AddAggregatedColumn(nameof(Purchase.amount), DataGridLastRow.AggreagteAction.Sum);
            dataGridView1.LastRowGrid = buyerGridLastRow;

            dataGridView1.InsertColumns(new Purchase().GetGridColumns());

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;


        }

        private void AmountDriveAcion(List<decimal?> count, List<string> issue_cost)
        {
            if (count[0] != null && !string.IsNullOrWhiteSpace(issue_cost[0]))
            {
                long issue_cost_long = long.Parse(issue_cost[0]);
                fldAmount.Drivtion((count[0] * issue_cost_long).ToString(), FieldPanel.FieldType.Textbox);
            }
            else fldAmount.Drivtion(null, FieldPanel.FieldType.Textbox);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnRemove.Visible =btnEdit.Visible= dataGridView1.SelectedRows.Count == 1;
        }

        private string FundCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)fldFund.Combo_GetValue()).Key;
            return key;
        }

        protected override void LoadAsynch()
        {
        }
        public override void LoadAfterAsyncEditData(Action act = null)
        {
            if (view_mode == System.Web.UI.WebControls.FormViewMode.Edit)
            {
                if (act == null) LoadPurchaseList(edit_id);
                else act();
            }
        }
        private void LoadPurchaseList(long? deposit_id)
        {
            Dictionary<string, object> filter_input = new Dictionary<string, object> { [nameof(Purchase.deposit_id)] = deposit_id };
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderGettingData);
            asynch.CallAwaitable(() => new Purchase().LoadToDgvAsList(dataGridView1, filter_input), () =>
             {
                 EntityToEditObject.purchases = SRL.WinTools.DataGridViewTool.GetDataTableSourceBinded<Purchase>(dataGridView1);

             });
        }
        private void btnInsertPurchase_Click(object sender, EventArgs e)
        {
            UpdatePurchase(System.Web.UI.WebControls.FormViewMode.Insert);
        }

        private void UpdatePurchase(System.Web.UI.WebControls.FormViewMode view_mode)
        {
            long amount;
            if (long.TryParse(fldAmount.Text_GetValue(), out amount))
            {
                long amount_left = amount;
                if (buyerGridLastRow.Rows.Count == 1) amount_left = amount - (long)buyerGridLastRow[nameof(Purchase.amount), 0].Value;
                long id=0;
                if (view_mode == System.Web.UI.WebControls.FormViewMode.Edit)
                {
                    id = long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                    if (id == 0)
                    {
                        Constants.form_loader_loading.Warn(Constants.MessageText.PendingChangesMes("سرمایه گذار"));
                        return;
                    }
                }
                if (amount_left > 0 ||view_mode==System.Web.UI.WebControls.FormViewMode.Edit)
                {
                    var form = new FormLoader<Purchase>(new PurchaseForm(amount, amount_left, view_mode,id));
                    var dialog = form.ShowDialog();
                    if (dialog == DialogResult.OK)
                    {
                        Purchase purchase = form.EntityObject;
                        if(view_mode==System.Web.UI.WebControls.FormViewMode.Insert) dataGridView1.AddEntity(purchase);
                        else if (view_mode == System.Web.UI.WebControls.FormViewMode.Edit)
                        {
                            dataGridView1.RemoveEntity<Purchase>();
                            dataGridView1.AddEntity(purchase);
                        }

                    }
                }
                else
                {
                    Constants.form_loader_loading.Warn(Constants.MessageText.RestrictionViolationMes("مبلغ"));
                }
            }
            else
            {
                Constants.form_loader_loading.Warn(Constants.MessageText.RequiredFieldErrorMes("مبلغ"));
            }
        }

        public async Task<List<KeyValuePair<string, string>>> TempUnits(string fund_id)
        {

            List<KeyValuePair<string, string>> temp_units = new List<KeyValuePair<string, string>>();
            if (!string.IsNullOrWhiteSpace(fund_id))
            {
                var filter = new SearchUnitCostRequest(null);
                var unit = new UnitCost();
                filter.fund_id = long.Parse(fund_id);
                HsborsResponse<List<UnitCost>> response = await unit.Search<UnitCost, SearchUnitCostRequest>(filter);
                var models = response.Model;
                foreach (var model in models)
                {
                    temp_units.Add(new KeyValuePair<string, string>(model.id.ToString(), model.hsdate));
                }
            }

            return temp_units;
        }

        protected override bool ChechUCValidation(ref string error)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                error = Constants.MessageText.DefaultDGVEmptyMes("سرمایه گذار");
                return false;
            }
            return true;
        }
        protected override void AddNonFormProperty(Deposit entity)
        {
            entity.purchases = SRL.WinTools.DataGridViewTool.GetDataSourceBinded<Purchase>(dataGridView1);
        }
        public override bool CheckFormEdited()
        {
            List<long> new_ids = EntityObject.purchases.Select(x => x.id).ToList();
            List<long> old_ids = EntityToEditObject.purchases.Select(x => x.id).ToList();
            if (new_ids.Where(x => !old_ids.Contains(x)).Any()) return true;
            if (old_ids.Where(x => !new_ids.Contains(x)).Any()) return true;
            return false;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DeletionConfirm() == DialogResult.Yes)
            {
                dataGridView1.RemoveEntity<Purchase>();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdatePurchase(System.Web.UI.WebControls.FormViewMode.Edit);
        }
    }

    public class NonGenericDepositFormUC : CustomUserControl<Deposit> { }
}
