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
    public partial class TextBoxField : FieldPanel
    {
        public TextBoxField()
        {
            InitializeComponent();
            AddControl(new CustomTextBox());
        }
        
    }
}
