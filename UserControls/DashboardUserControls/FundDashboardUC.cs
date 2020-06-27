using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp.UserControls.DashboardUserControls
{
    public partial class FundDashboardUC : CustomDashboardUC
    {
        public FundDashboardUC()
        {
            InitializeComponent();
        }
        protected override void LoadPage()
        {
            dgvFundStatus.InsertColumns(new FundDashboard().GetGridColumns());
           
        }

    }
}
