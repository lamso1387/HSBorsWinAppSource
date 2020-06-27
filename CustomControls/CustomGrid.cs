using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public partial class CustomGrid : DataGridView
    {
        public CustomGrid()
        {
            InitializeComponent();
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            //stop Auto Generating Columns in datasource set
            AutoGenerateColumns = false;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            Cursor = Cursors.Hand;
            DataGridViewCellStyle cell_style = new DataGridViewCellStyle();
            cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cell_style.BackColor = SystemColors.Window;

            cell_style.ForeColor = SystemColors.ControlText;
            cell_style.SelectionBackColor = SystemColors.GradientActiveCaption;
            cell_style.SelectionForeColor = SystemColors.ControlText;
            cell_style.WrapMode = DataGridViewTriState.False;
            DefaultCellStyle = cell_style;
            GridColor = SystemColors.ActiveCaption;

            ReadOnly = true;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllowUserToAddRows = false;
            //stop datagridview default error dialog: DataError += (s, e) => { e.Cancel = true; };

            BackgroundColor = SystemColors.ButtonFace;
            BackgroundColor = SystemColors.ControlLightLight;

            DataGridViewCellStyle header_style = new DataGridViewCellStyle();
            header_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            header_style.BackColor = SystemColors.Control;
            header_style.Font = new Font("B Yekan", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            header_style.ForeColor = SystemColors.WindowText;
            header_style.SelectionBackColor = SystemColors.Highlight;
            header_style.SelectionForeColor = SystemColors.HighlightText;
            header_style.WrapMode = DataGridViewTriState.True;

            ColumnHeadersDefaultCellStyle = header_style;
            RightToLeft = RightToLeft.Yes;

            this.DataSourceChanged += ModernDataGrid_DataSourceChanged;


        }
        public bool set_dgv_height_to_all_rows { get; set; } = false;


        private void ModernDataGrid_DataSourceChanged(object sender, EventArgs e)
        {
            if (set_dgv_height_to_all_rows)
            {
                this.Height = SRL.WinUI.DatagridviewClass.GetRowsHeaderHeight(this);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
