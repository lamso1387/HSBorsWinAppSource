using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;
using System.Globalization;

namespace HBorsWinApp
{
    public partial class DepositFilterUC : FilterUserControl
    {
        public DepositFilterUC()
        {
            InitializeComponent();
        }

        private void ProductsUC_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        private void LoadPage()
        { 
            LoadFunds();
            LoadAsync();
        }

        private void LoadFunds()
        {
           _= new Fund().LoadAllToComboBox(fund_panel);
        }

        private void LoadAsync()
        { 
        }



    }
}
