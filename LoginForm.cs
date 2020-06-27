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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == "0112233")
            {
                DialogResult = DialogResult.OK;
                
            }
            this.Close();

        }
    }
}
