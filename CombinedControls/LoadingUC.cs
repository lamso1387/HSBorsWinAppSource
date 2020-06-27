using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp.CombinedControls
{
    public partial class LoadingUC : UserControl
    {
        public string LblText
        {
            get => lblLoading.Text;
            set => lblLoading.Text = value;
        }
        public LoadingUC()
        {
            InitializeComponent();
        }
        public void StartLoader(string message)
        {
            LblText = message; 
            SRL.WinTools.LoadingCircleControl.StartLoading(loading_circle);
        }
        public void EndLoader()
        {
            LblText = ""; 
            SRL.WinTools.LoadingCircleControl.EndLoading(loading_circle);
        }
        internal async void Warn(string message,string detail=null, int duration= 3000)
        {
            LblText = string.IsNullOrWhiteSpace(message) ? Constants.MessageText.EmptyWarn : message;
            await Task.Delay(duration);
            LblText = "";
        }
    }
}
