using ExcelLibrary.Office.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public enum HsborsApiBaseUrl
    {
        [Description("https://localhost:44340/")]
        iisexpress,
        [Description("http://194.5.175.232/")]
        server,
        [Description("http://localhost:8081/")]
        localhost
    }
    public enum HsborsApiUrl
    {
        not_set = 0,
        [Description(@"{""method"":""POST"" ,""url"": ""api/deposit/search""}")]
        search_deposit_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/fund/search""}")]
        search_fund_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/unitcost/search""}")]
        search_unit_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/account/search""}")]
        search_account_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/user/search""}")]
        search_user_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/purchase/search""}")]
        search_purchase_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/setting/search""}")]
        search_setting_by_filters,
        [Description(@"{""method"":""POST"" ,""url"": ""api/deposit/add""}")]
        add_deposit,
        [Description(@"{""method"":""POST"" ,""url"": ""api/fund/add""}")]
        add_fund,
        [Description(@"{""method"":""POST"" ,""url"": ""api/unitcost/add""}")]
        add_unit_cost,
        [Description(@"{""method"":""POST"" ,""url"": ""api/user/add""}")]
        add_user,
        [Description(@"{""method"":""POST"" ,""url"": ""api/account/add""}")]
        add_account,
        [Description(@"{""method"":""POST"" ,""url"": ""api/setting/add""}")]
        add_setting,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/user/delete""}")]
        delete_user,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/fund/delete""}")]
        delete_fund,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/account/delete""}")]
        delete_account,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/unitcost/delete""}")]
        delete_unit_cost,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/deposit/delete""}")]
        delete_deposit,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/purchase/delete""}")]
        delete_purchase,
        [Description(@"{""method"":""DELETE"" ,""url"": ""api/setting/delete""}")]
        delete_setting,
        [Description(@"{""method"":""GET"" ,""url"": ""api/fund""}")]
        get_fund,
        [Description(@"{""method"":""GET"" ,""url"": ""api/user""}")]
        get_user,
        [Description(@"{""method"":""GET"" ,""url"": ""api/account""}")]
        get_account,
        [Description(@"{""method"":""GET"" ,""url"": ""api/unitcost""}")]
        get_unitcost,
        [Description(@"{""method"":""GET"" ,""url"": ""api/deposit""}")]
        get_deposit,
        [Description(@"{""method"":""GET"" ,""url"": ""api/purchase""}")]
        get_purchase,
        [Description(@"{""method"":""GET"" ,""url"": ""api/setting""}")]
        get_setting,
        [Description(@"{""method"":""PUT"" ,""url"": ""api/account/edit""}")]
        edit_account,
        [Description(@"{""method"":""PUT"" ,""url"": ""api/fund/edit""}")]
        edit_fund,
        [Description(@"{""method"":""PUT"" ,""url"": ""api/user/edit""}")]
        edit_user,
        [Description(@"{""method"":""PUT"" ,""url"": ""api/unitcost/edit""}")]
        edit_unitcost,
        [Description(@"{""method"":""PUT"" ,""url"": ""api/deposit/edit""}")]
        edit_deposit,
        [Description(@"{""method"":""PUT"" ,""url"": ""api/setting/edit""}")]
        edit_setting,
        [Description(@"{""method"":""POST"" ,""url"": ""api/fund/dashboard/search""}")]
        search_fund_dashboard,
        [Description(@"{""method"":""POST"" ,""url"": ""api/user/dashboard/profitloss/search""}")]
        search_user_profitloss_dashboard
    }


    public class HSApiDescription
    {
        public SRL.Web.HttpMethodEnum method { get; set; }
        public string url { get; set; }
        public static HSApiDescription GetHsborsApi<T>(T key)
        {
            string enum_des_str = SRL.ClassManagement.GetEnumDescription<T>(key);
            HSApiDescription enum_des = Newtonsoft.Json.JsonConvert.DeserializeObject<HSApiDescription>(enum_des_str);
            return enum_des;
        }
    }
    public class PagedRequest
    {
        public PagedRequest(DataGridList dgv)
        {
            if (dgv != null)
            {
                page_start = dgv.page_start;
                page_size = dgv.page_size;
            }

        }
        public int page_start { get; set; } //1
        public int page_size { get; set; } //100
    }

    public class SearchDepositRequest : PagedRequest
    {
        public SearchDepositRequest(DataGridList dgv) : base(dgv)
        {

        }
        public int? fund_id { get; set; }
    }
    public class SearchFundRequest : PagedRequest
    {
        public SearchFundRequest(DataGridList dgv = null) : base(dgv)
        {

        }
        public long? id { get; set; }
    }
    public class SearchUserRequest : PagedRequest
    {
        public SearchUserRequest(DataGridList dgv = null) : base(dgv)
        {

        }
        public long? id { get; set; }
    }
    public class SearchSettingRequest : PagedRequest
    {
        public SearchSettingRequest(DataGridList dgv = null) : base(dgv)
        {

        }
        public long? id { get; set; }
    }
    public class SearchPurchaseRequest : PagedRequest
    {
        public SearchPurchaseRequest(DataGridList dgv) : base(dgv)
        {

        }
        public long? id { get; set; }
        public long? deposit_id { get; set; }
    }

    public class SearchAccountRequest : PagedRequest
    {
        public SearchAccountRequest(DataGridList dgv = null) : base(dgv)
        {

        }
        public int? id { get; set; }
        public int? fund_id { get; set; }
    }
    public class SearchUnitCostRequest : PagedRequest
    {
        public SearchUnitCostRequest(DataGridList dgv) : base(dgv)
        {

        }
        public long? id { get; set; }
        public long? fund_id { get; set; }
    }

    public class HsborsResponse<TModel> : SRL.Web.ServerResponse<TModel>
    {
        protected override string base_address
        {
            get => SRL.ClassManagement.GetEnumDescription(Settings.hsbors_api_base_Url);//Settings.GetSettingValue(Settings.Settingkey.hsbors_base_address);
            set { }
        }

        protected override Type ModelType { get; set; } = typeof(HsborsResponse<TModel>);

        public override async Task RequestServer<T>(T url, object body, string url_load = null)
        {
            HSApiDescription enum_des = null;
            await Task.Run(() =>
             {
                 enum_des = HSApiDescription.GetHsborsApi(url);
             });
            if (enum_des.method == SRL.Web.HttpMethodEnum.GET)
            {
                await GetAsync($"{enum_des.url}/{url_load}");
            }
            else if ((enum_des.method == SRL.Web.HttpMethodEnum.POST))
            {
                await PostAsync(enum_des.url, body);
            }
            else if ((enum_des.method == SRL.Web.HttpMethodEnum.DELETE))
            {
                await DeleteAsync(enum_des.url, body);
            }
            else if ((enum_des.method == SRL.Web.HttpMethodEnum.PUT))
            {
                await PutAsync(enum_des.url, body);
            }



        }

    }

}
