using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public partial class CustomCombo : ComboBox
    {
        public Func<string, Task<List<KeyValuePair<string, string>>>> lookup_action { get; set; }
        List<KeyValuePair<string, string>> source;
        public CustomCombo()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.SystemColors.Window;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FormattingEnabled = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "field";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(150, 21);
            this.TabIndex = 1;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public async Task BindData(string key,Action call_back=null)
        {
            Text = "منتظر بمانید..."; 
            source = new List<KeyValuePair<string, string>>();
            source = await lookup_action(key);
            LoadToCombo();
            call_back?.Invoke();
        }
        private void LoadToCombo()
        {
            source.Insert(0, new KeyValuePair<string, string>("", "انتخاب کنید"));
            SRL.WinTools.ComboTool.LoadComboWithDic(this, source);
        }
         
    }
}
