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
#if DEBUG
    public partial class FundFormUC : NonGenericFundFormUC
#else
    public partial class FundFormUC :  CustomUserControl<Fund>
#endif 
    {
        public FundFormUC(System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
        {
            view_mode = view_mode_;
            edit_id = id_;

            InitializeComponent();
        }

        private void FundFormUC_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        protected override void LoadPage()
        {
            LoadAsynch();
        }
        protected override void LoadAsynch()
        { 
        }
        public async override Task AddAction()
        {
            Fund fund = EntityObject;
            HsborsResponse<Fund> response = await fund.Add<Fund>();
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderGettingData);
            asynch.CallAwaitable(() => CachedData.CacheAccounts(), null, null);
            asynch.CallAwaitable(() => CachedData.CacheFunds(), null, null);
        } 
    }

    public class NonGenericFundFormUC : CustomUserControl<Fund> { }
}
