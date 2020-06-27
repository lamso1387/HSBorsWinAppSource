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
    public partial class UserFormUC : NonGenericUserFormUC
#else
    public partial class UserFormUC :  CustomUserControl<User>
#endif 
    {
        public UserFormUC(System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
        {
            view_mode = view_mode_;
            edit_id = id_;
            InitializeComponent();
        }

        private void UnitCostFormUC_Load(object sender, EventArgs e)
        {

            LoadPage();
        }
        protected override void LoadPage()
        {
            LoadAsynch();
        }
        protected override void AddNonFormProperty(User entity)
        {
        }

    }

    public class NonGenericUserFormUC : CustomUserControl<User> { }
}
