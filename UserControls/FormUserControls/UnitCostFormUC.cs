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
    public partial class UnitCostFormUC : NonGenericUnitCostFormUC
#else
    public partial class UnitCostFormUC :  CustomUserControl<UnitCost>
#endif 
    {
        public UnitCostFormUC(System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
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
           _= new Fund().LoadAllToComboBox(flbFund);
            LoadAsynch();
        }
        protected override void LoadAsynch()
        {
            if ( true && view_mode == System.Web.UI.WebControls.FormViewMode.Edit)
            {
                AsynchAction asynk = new AsynchAction(Constants.MessageText.LoadFormEditData, true, Constants.form_loader_loading);
                asynk.CallAwaitable(() => LoadDataToEdit(),()=> {
                   
                });
                
            }
        }
        protected override void AddNonFormProperty(UnitCost entity)
        {
            entity.date = HSDate.ToEnglish(fldDate.field.Text);
        }

    }

    public class NonGenericUnitCostFormUC : CustomUserControl<UnitCost> { }
}
