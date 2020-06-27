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
    public partial class CustomTextPersian : TextBox
    {
        public CustomTextPersian()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.SystemColors.Window;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "field";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(150, 21);
            this.TabIndex = 1; 
            this.KeyPress += CustomFieldText_KeyPress;
        }
         

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void CustomFieldText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)  &&  !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\p{IsArabic}")
        && !string.IsNullOrWhiteSpace(e.KeyChar.ToString())) //&& !char.IsDigit(e.KeyChar)
                e.Handled = true;

        }
    }
}
