using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public partial class TextNumberField : FieldPanel
    {
        public TextNumberField()
        {
            InitializeComponent();
            AddControl(new CustomTextNumber());
            if (csReadOnly)
            {
                //باید منتقل شود به خود پنل اینجا کار نمیکند
                this.field.KeyPress += TextNumberField_KeyPress;
                this.field.BackColor = Color.Gray;
            }
        }
        private void TextNumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
