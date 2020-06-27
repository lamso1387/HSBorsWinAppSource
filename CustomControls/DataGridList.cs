using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic;

namespace HBorsWinApp
{
    public partial class DataGridList : CustomGrid
    {
        public DataGridLastRow LastRowGrid { get; set; }
        string id_column_name = "id";
        public int page_start { get; set; } //1
        public int page_size { get; set; } //100
        public int entity_count_all { get; set; }
        public int entity_page_count { get; set; }
        public DataGridList()
        {
            InitializeComponent();
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
                        case DataGridLastRow.AggreagteAction.Sum:
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
                        case DataGridLastRow.AggreagteAction.Sum:
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

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
