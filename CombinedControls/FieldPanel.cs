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
    public partial class FieldPanel : UserControl
    {
        public string csFieldName
        {
            get { return field.Name; }
            set { field.Name = value; }
        }
        public string csTitleText
        {
            get { return title.Text; }
            set { title.Text = value; }
        }
        public string csControlText
        {
            get { return field.Text; }
            set { field.Text = value; }
        }
        public bool csReadOnly { get; set; } = false;

        public bool csFormField { get; set; } = true;
       
        public enum FieldType
        {
            Textbox,
            Combo,
            Numeric
        }
        public Control field { get; set; }
        public Func<string, Task<bool>> enabled_action { get; set; }
        public Func<string, Task<string>> driven_action { get; set; }
        public FieldPanel()
        {
            InitializeComponent();
        }
        public async void Enablation(string key)
        {
            bool enable = await enabled_action(key);
            if (enable)
            {
                field.Enabled = true;
            }
            else
            {
                field.Enabled = false;
                field.ResetText();
                //  ResetValue();
            }

        }
        public async void Drivtion(string key, FieldType field_type)
        {
            string result = await driven_action(key);
            if (string.IsNullOrWhiteSpace(result))
            {
                field.ResetText();
            }
            else
            {
                switch (field_type)
                {
                    case FieldType.Textbox:
                        field.Text = result;
                        break;
                    case FieldType.Combo:
                        Combo_SetValue(result);
                        break;
                    case FieldType.Numeric:
                        break;
                    default:
                        break;
                }

            }

        }

        private void ResetValue()
        {
            if (field is TextBox) field.Text = "";
            else if (field is ComboBox) Combo_SetValue("");
            else if (field is NumericUpDown) (field as NumericUpDown).ResetText();
        }

        public void AddControl(Control control)
        {

            this.pnlField.Controls.Add(control);
            field = control;

        }
        public void Combo_SelectedIndexChangedResult(List<string> result_first)
        {
            result_first.Add(null);
            Action<object, EventArgs> act = (s, e) => result_first[0] = Combo_SelectedIndexChangedEvent();
            Combo_SelectedIndexChanged(act);

        }
        public void Combo_SelectedIndexChanged(Action<object, EventArgs> act)
        {
            (field as ComboBox).SelectedIndexChanged += (s, e) =>
         {
             act?.Invoke(s, e);
         };
        }
        private string Combo_SelectedIndexChangedEvent()
        {
            string key = (string)((KeyValuePair<string, string>)Combo_GetValue()).Key;
            return key;
        }
        public void Numeric_ValueChangedResult(List<decimal?> result_first)
        {
            result_first.Add(null);
            Action<object, EventArgs> act = (s, e) => result_first[0] = Numeric_ValueChangedEvent();
            Numeric_ValueChanged(act);
        }
        public void Numeric_ValueChanged(Action<object, EventArgs> act)
        {
            (field as NumericUpDown).ValueChanged += (s, e) =>
            {
                act?.Invoke(s, e);
            };
        }

        public void Text_ValueChangedResult(List<string> result_first)
        {
            result_first.Add(null);
            Action<object, EventArgs> act = (s, e) => result_first[0] = Text_ValueChangedEvent();
            Text_ValueChanged(act);
        }
        public void Text_ValueChanged(Action<object, EventArgs> act)
        {
            (field as TextBox).TextChanged += (s, e) =>
            {
                act?.Invoke(s, e);
            };
        }
        private decimal Numeric_ValueChangedEvent()
        {
            decimal key = ((NumericUpDown)field).Value;
            return key;
        }

        private string Text_ValueChangedEvent()
        {
            string key = ((TextBox)field).Text;
            return key;
        }

        public void SetValue(object value)
        {
            if (field is ComboBox) Combo_SetValue(value);
            else if (field is TextBox) Text_SetText(value?.ToString());
            else if (field is NumericUpDown) Numeric_SetText(long.Parse(value?.ToString()));
        }
        class ComboSourceProp
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }
        public void Combo_SetValue(object key)
        {
            string source_json = SRL.Json.ClassObjectToJson((field as ComboBox).DataSource);
            if (source_json != null)
            {
                List<ComboSourceProp> source_list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ComboSourceProp>>(source_json);
                int index = 0;
                foreach (var item in source_list)
                {
                    if (item.Key == key?.ToString())
                    {
                        index = source_list.IndexOf(item);
                        break;
                    }
                }
            (field as ComboBox).SelectedIndex = index;
            }
        }
        public object Combo_GetValue()
        {
            return (field as ComboBox).SelectedValue;
        }
        public string Combo_GetText()
        {
            string key = (string)((KeyValuePair<string, string>)Combo_GetValue()).Key;
            string value =string.IsNullOrWhiteSpace(key)? "": (string)((KeyValuePair<string, string>)Combo_GetValue()).Value;
            return value;
        }
        public string Text_GetValue()
        {
            return (field as TextBox).Text;
        }
        public void Text_SetText(string value)
        {
            (field as TextBox).Text = value;
        }
        public void Numeric_SetText(long value)
        {
            (field as NumericUpDown).Value = value;
        }


    }
}
