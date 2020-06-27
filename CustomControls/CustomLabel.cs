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
    public partial class CustomLabel : Label
    {
        public CustomLabel()
        {
            InitializeComponent();

            this.AutoSize = true;
            this.Dock = System.Windows.Forms.DockStyle.Right;
            this.Location = new System.Drawing.Point(95, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name = "title";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(55, 13);
            this.TabIndex = 0;
            this.Text = "عنوان فیلد";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
