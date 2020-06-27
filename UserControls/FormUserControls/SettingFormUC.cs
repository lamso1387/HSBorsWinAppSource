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
    public partial class SettingFormUC : NonGenericSettingFormUC
#else
    public partial class SettingFormUC :  CustomUserControl<Setting>
#endif 
    {
        public SettingFormUC(System.Web.UI.WebControls.FormViewMode view_mode_ = System.Web.UI.WebControls.FormViewMode.Insert, long? id_ = null)
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
            CustomCombo cbType = fldType.field as CustomCombo;
            cbType.lookup_action = (key) =>
            {
                List<KeyValuePair<string, string>> source = new List<KeyValuePair<string, string>>();
                var enum_list = (Setting.SettingType[])Enum.GetValues(typeof(Setting.SettingType));
                foreach (Setting.SettingType setting in enum_list)
                {
                    string des = SRL.ClassManagement.GetEnumDescription(setting);
                    var keypair = new KeyValuePair<string, string>(setting.ToString(), des);
                    source.Add(keypair);
                }
                return Task.FromResult(source);
            };
            _ = cbType.BindData(null);

            List<string> setting_type = new List<string>();
            fldType.Combo_SelectedIndexChangedResult(setting_type);

            fldKey.enabled_action = (key) =>
            {
                return Task.FromResult(key != Setting.SettingType.AnnualProfit.ToString());
            };
            fldType.Combo_SelectedIndexChanged((s, e) => fldKey.Enablation(setting_type[0]));
            fldKey.Enablation(setting_type[0]);

            
            fldKey.driven_action = (key) =>
              {
                  string rez = null;
                  if (key == Setting.SettingType.AnnualProfit.ToString())
                      rez = Setting.SettingType.AnnualProfit.ToString();
                  return Task.FromResult(rez);
              };
            fldType.Combo_SelectedIndexChanged((s, e) => { fldKey.Drivtion(setting_type[0], FieldPanel.FieldType.Textbox); });

           
            LoadAsynch();
        }
        protected override void AddNonFormProperty(Setting entity)
        {
        }

    }

    public class NonGenericSettingFormUC : CustomUserControl<Setting> { }
}
