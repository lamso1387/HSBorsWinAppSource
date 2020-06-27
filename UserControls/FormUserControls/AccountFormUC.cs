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
    public partial class AccountFormUC : NonGenericAccountFormUC
#else
    public partial class AccountFormUC :  CustomUserControl<Account>
#endif 
    {
        public AccountFormUC(System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
        {
            view_mode = view_mode_;
            edit_id = id_;
            InitializeComponent();
        }

        private void UnitCostFormUC_Load(object sender, EventArgs e)
        {

            LoadPage();
        }
        protected async override void LoadPage()
        {

            await new Fund().LoadAllToComboBox(fldFund);

            LoadAsynch();
        }
        protected override void LoadAsynch()
        {
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderAppOperation);
            asynch.CallAwaitable(() =>
            new User().LoadAllToComboBox((ComboBox)fldAccounter.field),
                () => LoadAfterAsyncEditData(()=> {
                    
                        fldFund.SetValue(EntityToEditObject.fund_id);
                }));
        } 
        public async override Task AddAction()
        {
            Account unit = EntityObject;
            HsborsResponse<Account> response = await unit.Add<Account>();
            AsynchAction asynch = new AsynchAction(Constants.MessageText.DefaultLoaderGettingData);
            asynch.CallAwaitable(() => CachedData.CacheAccounts(), null, null);
        }
        public override void LoadAfterAsyncEditData(Action act = null)
        {
            
        }

    }

    public class NonGenericAccountFormUC : CustomUserControl<Account> { }
}
