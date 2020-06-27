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
    public partial class CustomCheckBox : CheckBox
    {
        public CustomCheckBox()
        { 
            InitializeComponent();

            //this.BackColor = System.Drawing.SystemColors.Window;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "field";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(150, 20);
            this.TabIndex = 1;
            this.ResetText();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
