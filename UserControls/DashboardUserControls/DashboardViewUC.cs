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
using System.Data.SqlClient;
using System.Data.Entity.Core.Mapping;

namespace HBorsWinApp
{

    public partial class DashboardViewUC : CustomDashboardUC 
    { 
        FilterUserControl filter_control;
        public DashboardViewUC(CustomDashboardUC dashboard_, FilterUserControl filter_)
        { 
            filter_control = filter_;
            InitializeComponent();
           // fillChart();
            //  pnlDashboard.LoadingUC(dashboard_);

        }
        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            
            chart1.Series["Salary"].Points.AddXY("Ajay", "10000");
            chart1.Series["Salary"].Points.AddXY("Ramesh", "8000");
            chart1.Series["Salary"].Points.AddXY("Ankit", "7000");
            chart1.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            chart1.Series["Salary"].Points.AddXY("Suresh", "8500");
            //chart title  
            chart1.Titles.Add("سهم صندوق ها از سود");
        }
        

        private void ProductsUC_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        protected override void LoadPage()
        {
            dgvDashboard.set_dgv_height_to_all_rows = true;
            dgvUserProfitLoss.set_dgv_height_to_all_rows = true;

            dgvLastRow.AddAggregatedColumn(nameof(Fund.total_amount), DataGridLastRow.AggreagteAction.Sum);
            dgvLastRow.AddAggregatedColumn(nameof(Fund.capital_value), DataGridLastRow.AggreagteAction.Sum);
            dgvLastRow.AddAggregatedColumn(nameof(Fund.balanced_profit_average_percent), DataGridLastRow.AggreagteAction.Sum);
            dgvLastRow.AddAggregatedColumn(nameof(Fund.profit), DataGridLastRow.AggreagteAction.Sum);
            dgvDashboard.LastRowGrid = dgvLastRow;
                
            LoadAsynch();
        }
         

        protected override void LoadAsynch()
        {
            LoadFundDashbord();
            LoadProfitLossDashbord();
        }
         

        private  void LoadFundDashbord()
        { 
             
            List<Fund> funds = new List<Fund>();
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultDashboardGettingData);
            asynch.CallAwaitable(async () => funds= await new Fund().LoadDashboardToDgv(dgvDashboard),
                ()=>
                {
                    lblAverageTotalAmount.Text =((decimal?) funds.Sum(x => x.profit) / funds.Sum(x => x.total_amount) *100)?.ToString(Settings.decimal_format);
                    var fund_shares = funds.Select(x => new { x.name, x.profit_share });
                    fillChartDb(fund_shares);
                });

        }

        private void LoadProfitLossDashbord()
        { 
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultDashboardGettingData,true,null, profit_losses_loadingCircle);
            asynch.CallAwaitable(() =>  new User().LoadProfitLossDashboardToDgv(dgvUserProfitLoss));

        }
        private void fillChartDb(object fund_shares)
        {
           // SRL.WinChart.ShowDataOnChart()
            chart1.Series["Salary"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.DataSource = fund_shares;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Salary"].XValueMember = "name";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Salary"].YValueMembers = "profit_share";
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadFundDashbord();
        }
    }

}
