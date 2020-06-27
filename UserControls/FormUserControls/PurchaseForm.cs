using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Data.Entity.Core.Metadata.Edm;
using System.Runtime.Remoting.Messaging;
using System.Configuration;

namespace HBorsWinApp
{
#if DEBUG 
    public partial class PurchaseForm : NonGenericPurchaseForm
#else
    public partial class PurchaseForm : CustomUserControl<Purchase>
#endif 
    {
        long total_amount { get; set; }
        long left_amount { get; set; }
        public PurchaseForm(long amount_, long left_amount_, System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
        {
            view_mode = view_mode_;
            edit_id = id_;
            total_amount = amount_;
            left_amount = left_amount_;
            InitializeComponent();
        }
        protected override void AddNonFormProperty(Purchase entity)
        {
            entity.buyer_name = SRL.WinTools.ComboTool.GetKeyValue(fldPurchaser.field as ComboBox).Value;
            entity.bank_copartner_name = fldPartner.Combo_GetText();
        }
        private void PurchaseForm_Load(object sender, EventArgs e)
        {

            LoadPage();
        }
        enum CalcType
        {
            percent,
            kasri,
            number

        }
        protected override void LoadPage()
        {
            CustomCombo cbCalc = fldCalcType.field as CustomCombo;
            cbCalc.lookup_action = (key) =>
            {
                List<KeyValuePair<string, string>> source = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>(CalcType.percent.ToString(), "درصدی"),
                new KeyValuePair<string, string>(CalcType.number.ToString(), "عددی")
                };

                return Task.FromResult(source);
            };
            _ = cbCalc.BindData(null);
            List<string> calc_type = new List<string>();
            fldCalcType.Combo_SelectedIndexChangedResult(calc_type);


            fldAmountPercent.enabled_action = (key) =>
            {
                return Task.FromResult(key == "percent");
            };
            fldCalcType.Combo_SelectedIndexChanged((s, e) => fldAmountPercent.Enablation(calc_type[0]));
            fldAmountPercent.Enablation(calc_type[0]);
            List<decimal?> tashim_percent = new List<decimal?>();
            fldAmountPercent.Numeric_ValueChangedResult(tashim_percent);

            fldKasrAz.enabled_action = (key) =>
            {
                return Task.FromResult(key == "kasri");
            };
            fldCalcType.Combo_SelectedIndexChanged((s, e) => fldKasrAz.Enablation(calc_type[0]));
            fldKasrAz.Enablation(calc_type[0]);
            List<decimal?> kasr_az = new List<decimal?>();
            fldKasrAz.Numeric_ValueChangedResult(kasr_az);


            fldKasrTa.enabled_action = (key) =>
            {
                return Task.FromResult(key == "kasri");
            };
            fldCalcType.Combo_SelectedIndexChanged((s, e) => fldKasrTa.Enablation(calc_type[0]));
            fldKasrTa.Enablation(calc_type[0]);
            List<decimal?> kasr_ta = new List<decimal?>();
            fldKasrTa.Numeric_ValueChangedResult(kasr_ta);


            fldAmount.enabled_action = (key) =>
            {
                return Task.FromResult(key == "number");
            };
            fldCalcType.Combo_SelectedIndexChanged((s, e) => fldAmount.Enablation(calc_type[0]));
            fldAmount.Enablation(calc_type[0]);
            fldAmount.driven_action = (key) =>
            {
                decimal percent;
                string result = null;
                if (decimal.TryParse(key, out percent))
                    result = ((long)(percent * total_amount)).ToString();
                return Task.FromResult(result);
            };
            fldAmountPercent.Numeric_ValueChanged((s, e) => fldAmount.Drivtion((tashim_percent[0] / 100)?.ToString(), FieldPanel.FieldType.Textbox));
            fldKasrAz.Numeric_ValueChanged((s, e) =>
            {
                if (kasr_az[0] != null && kasr_az[0] != 0 && kasr_ta[0] != null && kasr_ta[0] != 0)
                    fldAmount.Drivtion((kasr_az[0] / kasr_ta[0]).ToString(), FieldPanel.FieldType.Textbox);
            });
            fldKasrTa.Numeric_ValueChanged((s, e) =>
            {
                if (kasr_az[0] != null && kasr_az[0] != 0 && kasr_ta[0] != null && kasr_ta[0] != 0)
                    fldAmount.Drivtion((kasr_az[0] / kasr_ta[0]).ToString(), FieldPanel.FieldType.Textbox);
            });

            fldCalcType.Combo_SetValue(CalcType.percent.ToString());
            fldAmountPercent.Numeric_SetText(100);

            lblAmountLeft.Tag = "مبلغ قابل تخصیص: ";
            SetLeftAmount();
            LoadAsynch();


        }

        private void SetLeftAmount()
        {
            if (view_mode == FormViewMode.Insert)
            {
                lblAmountLeft.Text = lblAmountLeft.Tag.ToString() +  left_amount.ToString();
            }
        }
        public override void LoadAfterAsyncEditData(Action act = null)
        {
            if (view_mode == FormViewMode.Edit)
            {
                lblAmountLeft.Text = lblAmountLeft.Tag.ToString() +
                (left_amount + EntityToEditObject.amount).ToString();
                fldAmountPercent.SetValue(EntityToEditObject.amount * 100 / total_amount);
            }
        }
        protected override void LoadAsynch()
        {
            User user = new User();
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderAppOperation);
            asynch.CallAwaitable(() => user.LoadAllToComboBox((ComboBox)fldPurchaser.field));
            asynch.CallAwaitable(() => user.LoadAllToComboBox((ComboBox)fldPartner.field));

        }


        public override Task AddAction() => Task.FromResult(0);
        public override Task EditAction() => Task.FromResult(0);


    }

    public class NonGenericPurchaseForm : CustomUserControl<Purchase> { }
}
