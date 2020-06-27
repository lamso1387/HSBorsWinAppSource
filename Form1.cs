using HBorsWinApp.UserControls.DashboardUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Settings.hsbors_api_base_Url = HsborsApiBaseUrl.iisexpress;
        }

        private void seeProductMi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.hsbors_api_base_Url == HsborsApiBaseUrl.server) LoginAct();
            LoadPage();
        }

        private void LoginAct()
        {
            var r = new LoginForm();
            r.ShowDialog();
            if (r.DialogResult != DialogResult.OK)
                this.Close();
        }

        private void LoadPage()
        {
            main_loading.LblText = "";
            Constants.main_loader = main_loading;


            WindowState = FormWindowState.Maximized;

            SRL.WinUI.MenuClass.Style(menu, Color.DarkSlateGray, Color.White, Color.White, Color.DimGray, Color.DarkSlateGray, Color.Black, Color.Black);
            LoasAsynch();
        }

        private void LoasAsynch()
        {
            CacheDataAsync();
        }
        private void CacheDataAsync()
        {
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderGettingData);
            asynch.CallAwaitable(() => CachedData.CacheFunds(),
              () => asynch.CallAwaitable(() => CachedData.CacheAccounts(), null, null),
             (ex) =>
             SRL.MessageBoxForm2.Show(ex.Message + " " + ex.InnerException?.Message, Constants.MessageText.InternetConnectionError
             , SRL.MessageBoxForm2.Buttons.OK));


        }

        private void miUpdateCachedData_Click(object sender, EventArgs e)
        {
            LoasAsynch();
        }

        private void miDeposit_Click(object sender, EventArgs e)
        {
            //            pnlMain.LoadingUC(new ListSearchUC<Deposit, DepositFormUC,SearchDepositRequest>(new Deposit(), new DepositFilterUC()));
            pnlMain.LoadUC(new ListSearchUC<Deposit, DepositFormUC, SearchDepositRequest>(new Deposit(), new DepositFilterUC()));
        }

        private void سفارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.LoadUC(new ListSearchUC<Fund, FundFormUC,SearchFundRequest>(new Fund(), new DepositFilterUC()));

        }

        private void miSetting_Click(object sender, EventArgs e)
        {
            pnlMain.LoadUC(new ListSearchUC<UnitCost, UnitCostFormUC,SearchUnitCostRequest>(new UnitCost(), null));
        }

        private void miCache_Click(object sender, EventArgs e)
        {
            CacheDataAsync();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miUsers_Click(object sender, EventArgs e)
        {
            pnlMain.LoadUC(new ListSearchUC<User, UserFormUC,SearchUserRequest>(new User(), null));
        }

        private void miAccount_Click(object sender, EventArgs e)
        {
            pnlMain.LoadUC(new ListSearchUC<Account, AccountFormUC,SearchAccountRequest>(new Account(), null));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void miDashboard_Click(object sender, EventArgs e)
        {
            pnlMain.LoadUC(new DashboardViewUC(new FundDashboardUC(), null));
        }

        private void miSetting_Click_1(object sender, EventArgs e)
        { 
            pnlMain.LoadUC(new ListSearchUC<Setting, SettingFormUC, SearchSettingRequest>(new Setting(), null));
        }
    }
}
