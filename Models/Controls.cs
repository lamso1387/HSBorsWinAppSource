using ExcelLibrary.Office.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data;
using System.Linq.Dynamic;

namespace HBorsWinApp
{

    public class GridColumn
    {
        public string name { get; set; } 
        protected string text { get; set; }
        public virtual string Text { get => text; set => text = value; }
        public bool visible { get; set; } = true;
    }
    public class GridColumn<T> : GridColumn
    {
        public override string Text
        {
            get
            {
                if (text == null)
                {
                    var display_name = typeof(T).GetProperty(name).GetCustomAttributes(typeof(DisplayNameAttribute), true)
                .Cast<DisplayNameAttribute>().Single().DisplayName;
                    return display_name;
                }
                else return text;

            }
            set => text = value;
        } 
    }
    public class CustomForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
    public class FilterUserControl : UserControl
    {
    }
    public class LoaderPanel : Panel
    {
        public Task LoadUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uc);
            return Task.FromResult(0);
        }

        public void LoadUCWithChildSize(UserControl uc)
        {
            this.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            if (this.Height < uc.Height) this.Height = uc.Height;
            if (this.Width < uc.Width) this.Width = uc.Width;
            this.Controls.Add(uc);

        }
    }
    public class UserGridView2 : SRL.WinUI.DatagridviewClass.ModernDataGrid
    {
        public GridLastRowView2 LastRowGrid { get; set; }
        string id_column_name = "id";
        public int page_start { get; set; } //1
        public int page_size { get; set; } //100
        public int entity_count_all { get; set; }
        public int entity_page_count { get; set; }

        public UserGridView2() : base()
        {
            CellDoubleClick += UserGridView_CellDoubleClick;
        }

        private void UserGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this[id_column_name, e.RowIndex].Value.ToString();
        }

        public void BindData<T>(HsborsResponse<List<T>> response)
        {
            BindData(response.Model);
            entity_count_all = response.ItemsCount;
            entity_page_count = response.PageCount;
            UpdateLastRow<T>(response.Model);
        }
        public void BindData<T>(List<T> list)
        {
            var dt = SRL.Convertor.IEnumerableToDatatable.CopyToDataTable(list);
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            this.DataSource = source;
            // UpdateLastRow<T>(dt);
        }
        public void UpdateLastRow<T>(List<T> list)
        {
            if (LastRowGrid != null)
            {
                List<T> last_row_source = new List<T>();
                T last_row = SRL.ClassManagement.CreateInstance<T>();
                foreach (var item in LastRowGrid.GetAggregatedColumns())
                {
                    object row_value = null;
                    switch (item.act)
                    {
                        case GridLastRowView2.AggreagteAction.Sum:
                            Type property_type = SRL.ClassManagement.GetPropertyType<T>(item.column_name);
                            var query = list.Select(item.column_name);
                            var qJson = SRL.Json.ClassObjectToJson(query);
                            List<decimal?> row_obj_list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<decimal?>>(qJson);
                            row_value = row_obj_list.Sum();
                            break;
                        default:
                            break;
                    }
                    SRL.ClassManagement.SetPropertyAsObject<T>(item.column_name, last_row, row_value);
                }
                last_row_source.Add(last_row);
                LastRowGrid.BindData<T>(last_row_source);
            }
        }
        public void UpdateLastRow<T>(DataTable dt)
        {
            if (LastRowGrid != null)
            {
                List<T> last_row_source = new List<T>();
                T last_row = SRL.ClassManagement.CreateInstance<T>();
                foreach (var item in LastRowGrid.GetAggregatedColumns())
                {
                    object row_obj = null;
                    switch (item.act)
                    {
                        case GridLastRowView2.AggreagteAction.Sum:
                            row_obj = dt.Compute($"Sum({item.column_name})", string.Empty);
                            break;
                        default:
                            break;
                    }
                    SRL.ClassManagement.SetProperty<T>(item.column_name, last_row, row_obj);
                }
                last_row_source.Add(last_row);
                LastRowGrid.BindData<T>(last_row_source);
            }
        }

        internal void AddEntity<T>(T entity)
        {
            UpdateLastRow(
            SRL.WinTools.DataGridViewTool.InsertDataSourceItem(this, entity)
            );

        }
        internal void RemoveEntity<T>()
        {
            int row = SelectedRows[0].Index;
            UpdateLastRow(
           SRL.WinTools.DataGridViewTool.DeleteDataSourceItem<T>(this, row)
           );
        }
        public void InsertColumns(List<GridColumn> cols)
        {
            Columns.Clear();
            foreach (GridColumn item in cols)
            {
                DataGridViewColumn column = new DataGridViewColumn() { Name = item.name, DataPropertyName = item.name, HeaderText = item.Text, Visible = item.visible, CellTemplate = new DataGridViewTextBoxCell() };
                Columns.Insert(cols.IndexOf(item), column);
            }
            LastRowGrid?.InsertColumns(cols);
        }

    }

    public class GridLastRowView2 : UserGridView2
    {
        public enum AggreagteAction
        {
            Sum = 0
        }
        public class ColumnAggregation
        {
            public string column_name { get; set; }
            public AggreagteAction act { get; set; }
        }
        List<ColumnAggregation> AggregatedColumns;
        bool default_set = false;
        public GridLastRowView2()
        {
            ColumnHeadersVisible = false;
        }
        public void AddAggregatedColumn(string column_name, AggreagteAction act)
        {
            if (AggregatedColumns == null) AggregatedColumns = new List<ColumnAggregation>();
            AggregatedColumns.Add(new ColumnAggregation { column_name = column_name, act = act });

        }
        public List<ColumnAggregation> GetAggregatedColumns() => AggregatedColumns;

    }
    public class CustomUserControl<T> : UserControl where T : ListSearchEntity
    {
        public System.Web.UI.WebControls.FormViewMode view_mode;
        protected long? edit_id;
        public string FirstValidationError { get; set; }
        public T EntityObject { get; set; }
        public T EntityToEditObject { get; set; }
        public CustomUserControl()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        }

        protected virtual void LoadPage() { }
        protected virtual void LoadAsynch()
        {
        }
        protected virtual void AddNonFormProperty(T entity)
        { }
        protected virtual bool ChechUCValidation(ref string error)
        { return true; }
        public virtual bool CheckFormEdited()
        {
            return false;
        }

        public bool CheckFormValidation()
        {
            string error = null;
            bool is_valid = ChechUCValidation(ref error);
            if (!is_valid)
            {
                FirstValidationError = error;
                return false;
            }

            T entity = this.GetFormEntity<T>();
            is_valid = entity.CheckAttrbuteValidation();
            if (!is_valid)
            {
                FirstValidationError = entity.validation_errors.First();
                return false;
            }

            AddNonFormProperty(entity);

            is_valid = entity.CheckPropertyValidation();
            if (!is_valid)
            {
                FirstValidationError = entity.validation_errors.First();
                return false;
            }

            EntityObject = entity;
            return true;
        }
        public async Task LoadDataToEdit(Action call_back = null)
        {
            if (view_mode == System.Web.UI.WebControls.FormViewMode.Edit)
            {
                EntityToEditObject = SRL.ClassManagement.CreateInstance<T>();
                HsborsResponse<T> response = await EntityToEditObject.Get<T>(edit_id.ToString());
                EntityToEditObject = response.Model;
                List<FieldPanel> list = this.GetFormFielsPanels();
                foreach (var item in list)
                {
                    //if (!item.csFormField) continue;
                    string field_name = item.csFieldName;
                    var value = SRL.ClassManagement.GetProperty<T>(field_name, EntityToEditObject)?.ToString();
                    if (value != null)
                        (Controls.Find(item.Name, true).First() as FieldPanel).SetValue(value);
                }
                call_back?.Invoke();
            }

        }
        public virtual void LoadAfterAsyncEditData(Action act = null)
        {
            if (view_mode == System.Web.UI.WebControls.FormViewMode.Edit && act != null)
            {
                act();
            }

        }
        public async virtual Task AddAction()
        {
            await EntityObject.Add<T>();
        }
        public async virtual Task EditAction()
        {
            T entity = EntityObject;
            entity.id = (long)edit_id;
            await entity.Edit<T>();
        }

        public DialogResult DeletionConfirm()
        {
            return SRL.MessageBoxForm2.Show("آیا مطمئن هستید؟", "تاییدیه", SRL.MessageBoxForm2.Buttons.YesNo);
        }


    }
    public class CustomDashboardUC : UserControl
    {

        public CustomDashboardUC()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        }

        protected virtual void LoadPage() { }
        protected virtual void LoadAsynch()
        {
        }

    }
    public class LoaderLabel : Label
    {
        public void StartLoader(string message)
        {
            this.Text = message;
        }
        public void EndLoader()
        {
            this.Text = "";
        }
        internal async void Warn(string message)
        {
            this.Text = string.IsNullOrWhiteSpace(message) ? Constants.MessageText.EmptyWarn : message;
            await Task.Delay(3000);
            this.Text = "";
        }
    }

}
