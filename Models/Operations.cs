using ExcelLibrary.Office.Excel;
using HBorsWinApp.CombinedControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public class AsynchAction : SRL.ActionManagement.MethodCall.AsynceLoader
    {
        public LoadingUC loader { get; set; } = Constants.main_loader;
        SRL.WinTools.LoadingCircleControl.LoadingCircle else_loader;
        public override string loader_message { get; set; } = Constants.MessageText.DefaultLoader;
        public override bool loader_enabled { get; set; } = true;
        public override Action<Exception> default_error_call
        {
            get => (ex) => SRL.MessageBoxForm2.Show(ex.Message);
            set => base.default_error_call = value;
        }
        public AsynchAction(string loader_message_, bool loader_enabled_ = true, LoadingUC loader_ = null, SRL.WinTools.LoadingCircleControl.LoadingCircle  else_loader_=null)
        {
            loader_enabled = loader_enabled_;
            loader_message = loader_message_;
            if (loader_ != null) loader = loader_;
            else_loader = else_loader_;
        }

        protected override void StartLoader(string message = Constants.MessageText.DefaultLoader)
        {
            loader?.StartLoader(message);
            if(else_loader!=null)
                SRL.WinTools.LoadingCircleControl.StartLoading(else_loader);
        }
        protected override void EndLoader()
        {
            loader?.EndLoader();
            if (else_loader != null) SRL.WinTools.LoadingCircleControl.EndLoading(else_loader);
        }
        protected override void CatchFunction(Exception ex, Action<Exception> error_call)
        {
            switch (ex.GetType().Name)
            {
                case nameof(SRL.Web.ServerResponse<Fund>.AlarmException):
                    loader.Warn(ex.Message, ex.InnerException.Message);
                    break;
                case nameof(SRL.Web.ServerResponse<Fund>.PreconditionException):
                    PreconditionExceptionAction(ex.Message, ex.InnerException.Message, ex.InnerException.InnerException.Message);
                    break;
                case nameof(Exception):
                case nameof(JsonSerializationException):
                case nameof(SRL.Web.ServerResponse<Fund>.HttpException):
                default:
                    if (error_call == null) default_error_call?.Invoke(ex);
                    else error_call(ex);
                    if (loader_enabled) EndLoader();
                    break;
            }
        }

        protected override void PreconditionExceptionAction(string message, string error_code, string data)
        {
            ErrorCodes? code = (ErrorCodes?)int.Parse(error_code);
            Dictionary<string, object> data_json = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
            switch (code)
            {
                case ErrorCodes.FundCancelCostNotSet:
                    loader.Warn($"{message}: {data_json[nameof(Deposit.fund_name)]}");
                    break;
                default:
                    loader.Warn(message);
                    break;
            }
        }

    }
    public class Settings
    {
        public static HsborsApiBaseUrl hsbors_api_base_Url { get; set; }
        public static string decimal_format="0.##";
        public enum Settingkey
        {
            hsbors_base_address
        }

        public static string GetSettingValue(Settingkey key)
        {
            string file = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.txt"));
            Dictionary<string, string> setting_json = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(file);
            string value = setting_json[key.ToString()];
            return value;
        } 

    }
    public enum ErrorCodes
    {
        FundCancelCostNotSet = 7
    }
}
