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
    public partial class DataGridLastRow : DataGridList
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
     
        public void AddAggregatedColumn(string column_name, AggreagteAction act)
        {
            if (AggregatedColumns == null) AggregatedColumns = new List<ColumnAggregation>();
            AggregatedColumns.Add(new ColumnAggregation { column_name = column_name, act = act });

        }
        public List<ColumnAggregation> GetAggregatedColumns() => AggregatedColumns;
        public DataGridLastRow()
        {
            InitializeComponent();
            ColumnHeadersVisible = false;
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DefaultCellStyle = dataGridViewCellStyle2;
        }
             

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
