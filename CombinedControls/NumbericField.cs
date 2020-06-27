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
    public partial class NumbericField : FieldPanel
    {
        public NumbericField()
        {
            InitializeComponent();
            AddControl(new CustomNumeric());
        }

    }
}
