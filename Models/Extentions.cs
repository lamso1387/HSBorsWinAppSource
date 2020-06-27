using ExcelLibrary.Office.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public static class Extentions
    {
        public static T ToEntity<T>(this Dictionary<string, object> object_)
        {
            return SRL.Convertor.ClassToClass<T>(object_);
        }
        public static T ToRequestEntity<T>(this Dictionary<string, object> filters, DataGridList dgv) where T : PagedRequest
        {
            var filter = SRL.Convertor.ClassToClass<T>(filters);
            filter.page_start = dgv.page_start;
            filter.page_size = dgv.page_size;
            return filter;

        }
        public static List<Control> GetChildInputControls(this Control parent_control)
        {
            List<Control> controls = new List<Control>();
            if (parent_control != null)
                foreach (var item in SRL.ChildParent.GetAllChildrenControls(parent_control))
                {
                    if (item is FieldPanel) if ((item as FieldPanel).csFormField == false) continue;
                    if ((item is ComboBox) || (item is TextBox) || (item is NumericUpDown))
                        controls.Add(item);
                }

            return controls;
        }
        private static List<FieldPanel> GetFielsPanels(this Control parent_control)
        {
            List<FieldPanel> controls = new List<FieldPanel>();
            if (parent_control != null)
                foreach (var item in SRL.ChildParent.GetAllChildrenControls(parent_control))
                {
                    if (item is FieldPanel)
                        controls.Add(item as FieldPanel);
                }

            return controls;
        }
        public static List<FieldPanel> GetFormFielsPanels(this Control parent_control)
        {
            List<FieldPanel> all_controls = GetFielsPanels(parent_control);
            List<FieldPanel> form_controls = all_controls.Where(x => x.csFormField == true).ToList();
            return form_controls;
        }
        public static Dictionary<string, object> ConvertValuesToJson(this List<Control> controls)
        {
            Dictionary<string, object> filter_input = new Dictionary<string, object>();

            foreach (Control item in controls)
            {
                object value = null;

                if (item is ComboBox)
                {
                    KeyValuePair<string, string> kv = SRL.WinTools.ComboTool.GetKeyValue((item as ComboBox));
                    value = kv.Key;
                }
                //else if (item is CustomTextBox)
                //{
                //    string text=item.Text.Replace("/","");
                //    int year =int.Parse(text.Substring(0, 4));
                //    int month = int.Parse(text.Substring(4,2));
                //    int day = int.Parse(text.Substring(6, 2)); 
                //    value = SRL.Convertor.PersianToEnglishDate(year,month,day);
                //}
                else if (item is TextBox)
                {
                    value = item.Text;
                }
                else if (item is NumericUpDown)
                {
                    value = (item as NumericUpDown).Value;
                }
                filter_input[item.Name] = value;
            }
            return filter_input;
        }
        public static T GetFormEntity<T>(this Control parent_control)
        {
            List<Control> list = GetChildInputControls(parent_control);
            Dictionary<string, object> json = ConvertValuesToJson(list);
            T entity = ToEntity<T>(json);
            return entity;

        }

        public static string GetEnumDesc<T>(this string to_enum_desc)
        {
            T enum_member = to_enum_desc.ToEnumMember<T>();
            string desc = SRL.ClassManagement.GetEnumDescription(enum_member);
            return desc;
        }
        public static T ToEnumMember<T>(this string to_enum_member)
        {
            T enum_member = SRL.Convertor.StringToEnum<T>(to_enum_member); 
            return enum_member;
        }
    }
}
