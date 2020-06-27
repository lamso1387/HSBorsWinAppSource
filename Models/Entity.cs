using Bunifu.Core;
using ExcelLibrary.Office.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public class HSDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return true;
            string value_ = value.ToString();
            if (string.IsNullOrWhiteSpace(value_)) return true;
            if (value_.Length != 10) return false;
            if (value_.Substring(4, 1) != "/") return false;
            if (value_.Substring(7, 1) != "/") return false;
            string date = value_.Replace("/", "");
            int year, month, day;
            if (!int.TryParse(date.Substring(0, 4), out year)) return false;
            if (!int.TryParse(date.Substring(4, 2), out month)) return false;
            if (!int.TryParse(date.Substring(6, 2), out day)) return false;
            if (year < 1300) return false;
            if (month < 1 || month > 12) return false;
            if (day < 1 || day > 31) return false;
            return true;
        }

        public static DateTime ToEnglish(string hsdate)
        {
            string text = hsdate.Replace("/", "");
            int year = int.Parse(text.Substring(0, 4));
            int month = int.Parse(text.Substring(4, 2));
            int day = int.Parse(text.Substring(6, 2));
            DateTime dt = SRL.Convertor.PersianToEnglishDate(year, month, day);
            return dt;
        }
        public static string ToHSDate(DateTime? date)
        {
            string text = SRL.Convertor.EnglishToPersianDate(date);
            return text;
        }
    }
    public class EditableAttribute : Attribute
    {
    }
    public abstract class CreationProperty
    {
        public long creator_id { get; set; }
        public long? modifier_id { get; set; }
        public DateTime create_date { get; set; }
        public DateTime? modify_date { get; set; }
    }
    public abstract class CommonProperty : CreationProperty
    {
        public long id { get; set; }

    }
    public abstract class ListSearchEntity : CommonProperty
    {
        public HsborsApiUrl search_by_filter_api;
        public HsborsApiUrl delete_api;
        public HsborsApiUrl get_api;
        public HsborsApiUrl edit_api;
        //properties
        public List<string> validation_errors { get; set; }
        //methods
        public bool CheckAttrbuteValidation()
        {
            this.validation_errors = SRL.ClassManagement.CheckValidationAttribute(this);
            return this.validation_errors.Count() == 0 ? true : false;
        }
        //abstracts:
        //public abstract Task<HsborsResponse<List<Tentity>>> Search<Tentity, Tsearch>(Tsearch filter);
        //public abstract Task<HsborsResponse<Tentity>> Get<Tentity>(string id);
        public abstract Task<HsborsResponse<T>> Add<T>();
        //public abstract Task<HsborsResponse<T>> Edit<T>();
        //public abstract Task<HsborsResponse<bool>> Delete(long id);
        public abstract List<GridColumn> GetGridColumns();
        //virtuals:
        public virtual async Task LoadToDgv<Tentity, Tsearch>(DataGridList dgv, Dictionary<string, object> filters) where Tsearch : PagedRequest where Tentity : ListSearchEntity
        {
            var filter = filters.ToRequestEntity<Tsearch>(dgv);
            //var entity =SRL.ClassManagement.CreateInstance<Tentity>();
            HsborsResponse<List<Tentity>> response = await Search<Tentity, Tsearch>(filter);

            dgv.InsertColumns(GetGridColumns());

            dgv.BindData(response);
        }
        public virtual bool CheckPropertyValidation() { return true; }
        public virtual Task LoadToDgvAsList(DataGridList dgv, Dictionary<string, object> filters) { return null; }
        public virtual async Task<HsborsResponse<List<Tentity>>> Search<Tentity, Tsearch>(Tsearch filter)
        {
            var hsbors_server = new HsborsResponse<List<Tentity>>();
            await hsbors_server.RequestServer(search_by_filter_api, filter);
            return hsbors_server;
        }
        public virtual async Task<HsborsResponse<bool>> Delete(long id)
        {
            var hsbors_server = new HsborsResponse<bool>();
            await hsbors_server.RequestServer(delete_api, id);
            return hsbors_server;

        }
        public virtual async Task<HsborsResponse<Tentity>> Get<Tentity>(string id)
        {
            var hsbors_server = new HsborsResponse<Tentity>();
            await hsbors_server.RequestServer(get_api, null, id);
            return hsbors_server;
        }
        public virtual async Task<HsborsResponse<Tentity>> Edit<Tentity>()
        {
            var hsbors_server = new HsborsResponse<Tentity>();
            await hsbors_server.RequestServer(edit_api, this);
            return hsbors_server;
        }

    }
    public class Fund : ListSearchEntity
    {
        [Editable]
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("نام صندوق")]
        public string name { get; set; }
        [Editable]
        public string no { get; set; }
        public string status { get; set; }
        public List<Account> accounts { get; set; }

        //dashboard: 
        public long? total_amount { get; set; }
        public long? final_cancel_cost { get; set; }
        public long? capital_value { get; set; }
        public decimal? interest_rate { get; set; }
        public decimal? balanced_profit_average_percent { get; set; }
        public long? profit { get; set; }
        public DateTime? final_cancel_cost_date { get; set; }
        public string hsfinal_cancel_cost_date { get => HSDate.ToHSDate(final_cancel_cost_date); }
        public string final_cancel_cost_day { get => final_cancel_cost_date?.ToString("yyyy/MM/dd"); }
        public decimal? total_share { get; set; }
        public decimal? profit_share { get; set; }
        public decimal? profit_to_earnings_ratio { get; set; }
        public decimal? profit_to_investment { get; set; }
        public decimal? profit_year_forecast { get => profit_to_investment * 365; }
        public Fund()
        {
            search_by_filter_api = HsborsApiUrl.search_fund_by_filters;
            edit_api = HsborsApiUrl.edit_fund;
            delete_api = HsborsApiUrl.delete_fund;
            get_api = HsborsApiUrl.get_fund;
        }
        public override async Task<HsborsResponse<Fund>> Add<Fund>()
        {
            var hsbors_server = new HsborsResponse<Fund>();
            Dictionary<string, object> fund = new Dictionary<string, object>
            {
                [nameof(this.name)] = name,
                [nameof(this.no)] = no
            };
            await hsbors_server.RequestServer(HsborsApiUrl.add_fund, fund);
            return hsbors_server;
        }

        public async Task LoadAllToComboBox(FieldPanel fld)
        {
            CustomCombo cbFund = fld.field as CustomCombo;
            cbFund.lookup_action = (key) => GetFunds();
            await cbFund.BindData(null);
        }

        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Insert(0, new GridColumn { name = nameof(name), Text = "نام" });
            list.Insert(1, new GridColumn { name = nameof(id), Text = "ایدی", visible = false });
            return list;
        }
        public List<GridColumn> GetDashboardGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Add(new GridColumn { name = nameof(name), Text = "نام صندوق" });
            list.Add(new GridColumn { name = nameof(total_amount), Text = "هزینه خرید واحدهای صندوق" });
            list.Add(new GridColumn { name = nameof(capital_value), Text = "ارزش سرمایه صندوق" });
            list.Add(new GridColumn { name = nameof(interest_rate), Text = "درصد سود صندوق" });
            list.Add(new GridColumn { name = nameof(balanced_profit_average_percent), Text = "میانگین درصد سود موزون صندوق" });
            list.Add(new GridColumn { name = nameof(profit), Text = "میزان سود صندوق" });
            list.Add(new GridColumn { name = nameof(total_share), Text = "سهم از کل" });
            list.Add(new GridColumn { name = nameof(profit_share), Text = "سهم از سود" });
            list.Add(new GridColumn { name = nameof(profit_to_earnings_ratio), Text = "نسبت سود به سهم" });
            list.Add(new GridColumn { name = nameof(profit_to_investment), Text = "نسبت سود به مدت سرمایه‌گذاری" });
            list.Add(new GridColumn { name = nameof(profit_year_forecast), Text = "پیش بینی سود یکسال" });
            list.Add(new GridColumn { name = nameof(final_cancel_cost), Text = "قیمت ابطال روز صندوق" });
            list.Add(new GridColumn { name = nameof(hsfinal_cancel_cost_date), Text = "تاریخ قیمت ابطال" });
            list.Add(new GridColumn { name = nameof(final_cancel_cost_day), Text = "تاریخ ابطال میلادی" });

            return list;
        }

        public async Task<List<Fund>> LoadDashboardToDgv(DataGridList dgv)
        {
            var filter = new SearchFundRequest(dgv);

            HsborsResponse<List<Fund>> response = await SearchDashboard<Fund, SearchFundRequest>(filter);
            dgv.InsertColumns(GetDashboardGridColumns());

            dgv.BindData(response);
            return response.Model;

        }

        public async Task<HsborsResponse<List<Fund>>> SearchDashboard<Fund, SearchFundRequest>(SearchFundRequest filter)
        {
            var hsbors_server = new HsborsResponse<List<Fund>>();
            await hsbors_server.RequestServer(HsborsApiUrl.search_fund_dashboard, filter);
            return hsbors_server;
        }
        public Task<List<KeyValuePair<string, string>>> GetFunds()
        {
            List<KeyValuePair<string, string>> comboSource = new List<KeyValuePair<string, string>>();

            foreach (var item in CachedData.funds)
            {
                comboSource.Add(new KeyValuePair<string, string>(item.Key.ToString(), item.Value));
            }

            return Task.FromResult(comboSource);
        }

    }
    public class User : ListSearchEntity
    {
        [Editable]
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("نام")]
        public string first_name { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("نام خانوادگی")]
        [Editable]
        public string last_name { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("موبایل")]
        [SRL.Security.Mobile(ErrorMessage = Constants.MessageText.MobileFormatError)]
        [Editable]
        public string mobile { get; set; }
        //other 
        [DisplayName("نام و نام خانوادگی")]
        public string full_name { get => $"{first_name} {last_name}"; }
        //dashboard
        [DisplayName("کل مبلغ سرمایه‌گذاری")]
        public long total_amount_investment { get; set; }
        [DisplayName("ارزش کنونی سرمایه‌گذاری")]
        public long current_investment_value { get; set; }
        [DisplayName("سهم خالص سود به زیان بدون کارمزد")]
        public long net_profit_to_loss_share_without_commission { get; set; }
        [DisplayName("سود انتظاری بانکی")]
        public long expected_bank_interest { get; set; }
        public User()
        {
            search_by_filter_api = HsborsApiUrl.search_user_by_filters;
            edit_api = HsborsApiUrl.edit_user;
            delete_api = HsborsApiUrl.delete_user;
            get_api = HsborsApiUrl.get_user;
        }
        //public override async Task<HsborsResponse<List<User>>> Search<User, SearchUserRequest>(SearchUserRequest filter)
        //{
        //    var hsbors_server = new HsborsResponse<List<User>>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.search_user_by_filters, filter);
        //    return hsbors_server;
        //}
        public override async Task<HsborsResponse<User>> Add<User>()
        {
            var hsbors_server = new HsborsResponse<User>();
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                [nameof(this.first_name)] = first_name,
                [nameof(this.last_name)] = last_name,
                [nameof(this.mobile)] = mobile
            };
            await hsbors_server.RequestServer(HsborsApiUrl.add_user, user);
            return hsbors_server;

        }
        //public override async Task<HsborsResponse<bool>> Delete(long id)
        //{
        //    var hsbors_server = new HsborsResponse<bool>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.delete_user, id);
        //    return hsbors_server;

        //}

        public async Task LoadAllToComboBox(ComboBox combobox)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            comboSource.Add("", "انتخاب کنید");
            var user = new User();
            var response = await user.Search<User, SearchUserRequest>(new SearchUserRequest());
            var users = response.Model;

            foreach (var item in users)
            {
                comboSource.Add(item.id.ToString(), $"{item.first_name} {item.last_name}");
            }

            SRL.WinTools.ComboTool.LoadComboWithDic(combobox, comboSource);

        }

        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Insert(0, new GridColumn { name = nameof(first_name), Text = "نام" });
            list.Insert(1, new GridColumn { name = nameof(last_name), Text = "نام خانوادگی" });
            list.Insert(2, new GridColumn { name = nameof(mobile), Text = "موبایل" });
            list.Insert(3, new GridColumn { name = nameof(id), Text = "ایدی کاربر", visible = false });
            return list;
        }

        //public override async Task<HsborsResponse<User>> Get<User>(string id)
        //{
        //    var hsbors_server = new HsborsResponse<User>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.get_user, null, id);
        //    return hsbors_server;
        //}

        //public async override Task<HsborsResponse<User>> Edit<User>()
        //{
        //    var hsbors_server = new HsborsResponse<User>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.edit_user, this);
        //    return hsbors_server;
        //}
        public List<GridColumn> GetProfitLossDashboardGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Add(new GridColumn<User> { name = nameof(full_name), Text = null });  
            list.Add(new GridColumn<User> { name = nameof(total_amount_investment), Text = null });
            list.Add(new GridColumn<User> { name = nameof(current_investment_value), Text = null });
            list.Add(new GridColumn<User> { name = nameof(net_profit_to_loss_share_without_commission), Text = null });
            list.Add(new GridColumn<User> { name = nameof(expected_bank_interest), Text = null });

            return list;
        }

        public async Task<HsborsResponse<List<User>>> SearchProfitLossDashboard()
        {
            var hsbors_server = new HsborsResponse<List<User>>();
            await hsbors_server.RequestServer(HsborsApiUrl.search_user_profitloss_dashboard, null);
            return hsbors_server;
        }
        public async Task<List<User>> LoadProfitLossDashboardToDgv(DataGridList dgv)
        {
            HsborsResponse<List<User>> response = await SearchProfitLossDashboard();
            dgv.InsertColumns(GetProfitLossDashboardGridColumns());

            dgv.BindData(response);
            return response.Model;

        }
    }
    public class Account : ListSearchEntity
    {
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("صندوق")]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldErrorDynamic)]
        [Editable]
        public long? fund_id { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("صاحب حساب")]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldErrorDynamic)]
        [Editable]
        public long? accounter_id { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("نام حساب")]
        [Editable]
        public string name { get; set; }
        [Editable]
        public string no { get; set; }
        public string status { get; set; }
        public List<Deposit> deposits { get; set; }
        //other props:
        public string fund_name { get; set; }
        public string accounter_name { get; set; }
        public Account()
        {
            search_by_filter_api = HsborsApiUrl.search_account_by_filters;
            edit_api = HsborsApiUrl.edit_account;
            delete_api = HsborsApiUrl.delete_account;
            get_api = HsborsApiUrl.get_account;
        }
        //public override async Task<HsborsResponse<List<Account>>> Search<Account, SearchAccountRequest>(SearchAccountRequest filter)
        //{
        //    var hsbors_server = new HsborsResponse<List<Account>>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.search_account_by_filters, filter);
        //    return hsbors_server;
        //}
        public async override Task<HsborsResponse<Account>> Add<Account>()
        {
            var hsbors_server = new HsborsResponse<Account>();
            Dictionary<string, object> account = new Dictionary<string, object>
            {
                [nameof(this.accounter_id)] = accounter_id,
                [nameof(this.fund_id)] = fund_id,
                [nameof(this.name)] = name,
                [nameof(this.no)] = no
            };
            await hsbors_server.RequestServer(HsborsApiUrl.add_account, account);
            return hsbors_server;
        }

        public Task LoadAllToComboBox(ComboBox combobox)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            comboSource.Add("", "انتخاب کنید");
            foreach (var fund in CachedData.funds)
            {
                //comboSource.Add(fund.Key.ToString(), fund.Value);
            }

            SRL.WinTools.ComboTool.LoadComboWithDic(combobox, comboSource);
            return Task.FromResult(0);

        }

        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Insert(0, new GridColumn { name = nameof(name), Text = "نام" });
            list.Insert(0, new GridColumn { name = nameof(accounter_name), Text = "صاحب حساب" });
            list.Insert(0, new GridColumn { name = nameof(fund_name), Text = "صندوق" });
            list.Insert(0, new GridColumn { name = nameof(no), Text = "شماره حساب" });
            list.Insert(1, new GridColumn { name = nameof(id), Text = "ایدی", visible = false });
            return list;
        }
        public List<KeyValuePair<string, string>> GetAccounts(long? fund_id)
        {
            List<KeyValuePair<string, string>> comboSource = new List<KeyValuePair<string, string>>();
            var query = CachedData.accounts;
            if (fund_id.HasValue)
            {
                query = query.Where(x => x.fund_id == fund_id).ToList();
            }
            foreach (var item in query)
            {
                comboSource.Add(new KeyValuePair<string, string>(item.id.ToString(), item.name));
            }

            return comboSource;
        }

        //public override async Task<HsborsResponse<bool>> Delete(long id)
        //{
        //    var hsbors_server = new HsborsResponse<bool>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.delete_account, id);
        //    return hsbors_server;

        //}

        //public override async Task<HsborsResponse<Account>> Get<Account>(string id)
        //{
        //    var hsbors_server = new HsborsResponse<Account>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.get_account, null, id);
        //    return hsbors_server;
        //}

        //public async override Task<HsborsResponse<Account>> Edit<Account>()
        //{
        //    var hsbors_server = new HsborsResponse<Account>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.edit_account, this);
        //    return hsbors_server;
        //}
    }
    public class UnitCost : ListSearchEntity
    {
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic)]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldErrorDynamic), DisplayName("صندوق")]
        [Editable]
        public long? fund_id { get; set; }
        public DateTime? date { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("تاریخ اعلام هزینه")]
        [HSDate(ErrorMessage = Constants.MessageText.HSDateFormatErrorDynamic)]
        [Editable]
        public string hsdate { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic)]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldErrorDynamic), DisplayName("هزینه صدور")]
        [Editable]
        public long? issue_cost { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic)]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldErrorDynamic), DisplayName("هزینه ابطال")]
        [Editable]
        public long? cancel_cost { get; set; }
        //other props:
        public string fund_name { get; set; }
        public UnitCost()
        {
            search_by_filter_api = HsborsApiUrl.search_unit_by_filters;
            edit_api = HsborsApiUrl.edit_unitcost;
            delete_api = HsborsApiUrl.delete_unit_cost;
            get_api = HsborsApiUrl.get_unitcost;
        }
        public override async Task<HsborsResponse<List<T>>> Search<T, SearchUnitCostRequest>(SearchUnitCostRequest filter)
        {
            var hsbors_server = new HsborsResponse<List<T>>();
            await hsbors_server.RequestServer(HsborsApiUrl.search_unit_by_filters, filter);
            foreach (var item in hsbors_server.Model)
            {
                (item as UnitCost).hsdate = HSDate.ToHSDate((item as UnitCost).date);
            }
            return hsbors_server;
        }
        public override async Task<HsborsResponse<UnitCost>> Add<UnitCost>()
        {
            var hsbors_server = new HsborsResponse<UnitCost>();
            Dictionary<string, object> fund = new Dictionary<string, object>
            {
                [nameof(this.cancel_cost)] = cancel_cost,
                [nameof(this.date)] = date,
                [nameof(this.fund_id)] = fund_id,
                [nameof(this.issue_cost)] = issue_cost
            };
            await hsbors_server.RequestServer(HsborsApiUrl.add_unit_cost, fund);
            return hsbors_server;
        }

        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Insert(0, new GridColumn { name = nameof(hsdate), Text = "تاریخ" });
            list.Insert(1, new GridColumn { name = nameof(fund_name), Text = "صندوق" });
            list.Insert(2, new GridColumn { name = nameof(issue_cost), Text = "هزینه صدور" });
            list.Insert(3, new GridColumn { name = nameof(cancel_cost), Text = "هزینه ابطال" });
            list.Insert(4, new GridColumn { name = nameof(id), Text = "ایدی", visible = false });
            return list;
        }

        //public override async Task<HsborsResponse<bool>> Delete(long id)
        //{
        //    var hsbors_server = new HsborsResponse<bool>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.delete_unit_cost, id);
        //    return hsbors_server;

        //}
        public override async Task<HsborsResponse<T>> Get<T>(string id)
        {
            var hsbors_server = new HsborsResponse<T>();
            await hsbors_server.RequestServer(HsborsApiUrl.get_unitcost, null, id);
            string hsDate = HSDate.ToHSDate((DateTime)(hsbors_server.Model as UnitCost).date);
            (hsbors_server.Model as UnitCost).hsdate = hsDate;
            return hsbors_server;
        }

        //public async override Task<HsborsResponse<UnitCost>> Edit<UnitCost>()
        //{
        //    var hsbors_server = new HsborsResponse<UnitCost>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.edit_unitcost, this);
        //    return hsbors_server;
        //}
    }
    public class Deposit : ListSearchEntity
    {
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldError + ": هزینه ها")]
        [Editable]
        public long? unit_cost_id { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldError + ": حساب")]
        [Editable]
        public long? account_id { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldError + ": تعداد")]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldError + ": تعداد")]
        [Editable]
        public long? count { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldError + ": مبلغ")]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldError + ": مبلغ")]
        [Editable]
        public long? amount { get; set; }
        public string status { get; set; }
        public List<Purchase> purchases { get; set; }
        //other props:
        public string account_name { get; set; }
        public string fund_name { get; set; }
        public DateTime? date { get; set; }
        public string hsdate { get => HSDate.ToHSDate(date); }
        public long? issue_cost { get; set; }
        public long? cancel_cost { get; set; }
        public int? purchases_count { get; set; }
        public string purchasers_name { get => purchases?.Select(i => i.buyer_name).Aggregate((i, j) => i + ", " + j); }
        public string bank_corporators_name
        {
            get
            {

                if (purchases?.Where(x => !string.IsNullOrWhiteSpace(x.bank_copartner_name)).Count() > 0)
                    return purchases.Where(x => !string.IsNullOrWhiteSpace(x.bank_copartner_name)).Select(i => i.bank_copartner_name)?.Aggregate((i, j) => i + ", " + j);
                else return null;
            }
        }
        public long? fund_id { get => CachedData.accounts?.Where(x => x.id == account_id)?.First()?.fund_id; }
        public Deposit()
        {
            search_by_filter_api = HsborsApiUrl.search_deposit_by_filters;
            edit_api = HsborsApiUrl.edit_deposit;
            delete_api = HsborsApiUrl.delete_deposit;
            get_api = HsborsApiUrl.get_deposit;
        }

        public override bool CheckPropertyValidation()
        {
            bool is_valid = true;
            if (purchases.Sum(x => x.amount) != this.amount)
            {
                is_valid = false;
                validation_errors.Add(Constants.MessageText.PurcheseAmountSumError);
            }
            return is_valid;
        }
        //public override async Task<HsborsResponse<List<Deposit>>> Search<Deposit, SearchDepositRequest>(SearchDepositRequest filter)
        //{
        //    var hsbors_server = new HsborsResponse<List<Deposit>>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.search_deposit_by_filters, filter);
        //    return hsbors_server;
        //}

        public override async Task<HsborsResponse<Deposit>> Add<Deposit>()
        {
            var hsbors_server = new HsborsResponse<Deposit>();
            Dictionary<string, object> deposit = new Dictionary<string, object>
            {
                [nameof(this.account_id)] = account_id,
                [nameof(this.amount)] = amount,
                [nameof(this.count)] = count,
                [nameof(this.unit_cost_id)] = unit_cost_id
            };
            List<Dictionary<string, object>> purchases = new List<Dictionary<string, object>>();
            this.purchases.ForEach(x => purchases.Add(new Dictionary<string, object>
            {
                [nameof(Purchase.amount)] = x.amount,
                [nameof(Purchase.bank_copartner_id)] = x.bank_copartner_id,
                [nameof(Purchase.bank_copartner_intrest)] = x.bank_copartner_intrest,
                [nameof(Purchase.bank_copartner_percent)] = x.bank_copartner_percent,
                [nameof(Purchase.buyer_id)] = x.buyer_id
            }));
            deposit[nameof(this.purchases)] = purchases;
            await hsbors_server.RequestServer(HsborsApiUrl.add_deposit, deposit);
            return hsbors_server;
        }
        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Add(new GridColumn { name = nameof(account_name), Text = "حساب" });
            list.Add(new GridColumn { name = nameof(amount), Text = "مبلغ" });
            list.Add(new GridColumn { name = nameof(count), Text = "تعداد" });
            list.Add(new GridColumn { name = nameof(hsdate), Text = "تاریخ صدور" });
            list.Add(new GridColumn { name = nameof(issue_cost), Text = "هزینه صدور هر واحد" });
            list.Add(new GridColumn { name = nameof(purchasers_name), Text = "خریداران" });
            list.Add(new GridColumn { name = nameof(bank_corporators_name), Text = "شرکا" });
            list.Add(new GridColumn { name = nameof(account_id), Text = "ایدی حساب", visible = false });
            list.Add(new GridColumn { name = nameof(id), Text = "ایدی", visible = false });

            return list;
        }
        //public override async Task<HsborsResponse<bool>> Delete(long id)
        //{
        //    var hsbors_server = new HsborsResponse<bool>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.delete_deposit, id);
        //    return hsbors_server;

        //}
        //public override async Task<HsborsResponse<T>> Get<T>(string id)
        //{
        //    var hsbors_server = new HsborsResponse<T>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.get_deposit, null, id);
        //    return hsbors_server;
        //}
        //public async override Task<HsborsResponse<T>> Edit<T>()
        //{
        //    var hsbors_server = new HsborsResponse<T>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.edit_deposit, this);
        //    return hsbors_server;
        //}
    }
    public class Purchase : ListSearchEntity
    {
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldError + ": خریدار")]
        [Editable]
        public long? buyer_id { get; set; }
        public long? deposit_id { get; set; }
        [Editable]
        public long? bank_copartner_id { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldError + ": مبلغ")]
        [Range(1, int.MaxValue, ErrorMessage = Constants.MessageText.RangeFieldError + ": مبلغ")]
        [Editable]
        public long? amount { get; set; }
        [Editable]
        public int? bank_copartner_percent { get; set; }
        [Editable]
        public int? bank_copartner_intrest { get; set; }
        //other props:
        public string buyer_name { get; set; }

        public string bank_copartner_name { get; set; }
        public Purchase()
        {
            search_by_filter_api = HsborsApiUrl.search_purchase_by_filters;
            delete_api = HsborsApiUrl.delete_purchase;
            get_api = HsborsApiUrl.get_purchase;
        }

        //public override async Task<HsborsResponse<List<Purchase>>> Search<Purchase, SearchPurchaseRequest>(SearchPurchaseRequest filter)
        //{
        //    var hsbors_server = new HsborsResponse<List<Purchase>>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.search_purchase_by_filters, filter);
        //    return hsbors_server;
        //}
        public override Task<HsborsResponse<T>> Add<T>()
        {
            throw new NotImplementedException();
        }
        public override async Task LoadToDgv<Tentity, Tsearch>(DataGridList dgv, Dictionary<string, object> filters)
        {
            var response = await CreateDGVModel(dgv, filters);
            dgv.BindData(response);
        }

        private async Task<HsborsResponse<List<Purchase>>> CreateDGVModel(DataGridList dgv, Dictionary<string, object> filters)
        {
            var filter = filters.ToRequestEntity<SearchPurchaseRequest>(dgv);
            HsborsResponse<List<Purchase>> response = await Search<Purchase, SearchPurchaseRequest>(filter);
            dgv.InsertColumns(GetGridColumns());
            return response;
        }

        public override async Task LoadToDgvAsList(DataGridList dgv, Dictionary<string, object> filters)
        {
            var response = await CreateDGVModel(dgv, filters);
            foreach (var item in response.Model)
            {
                dgv.AddEntity(item);
            }

        }
        public override bool CheckPropertyValidation()
        {
            bool is_valid = true;
            if (bank_copartner_id != null && (!(bank_copartner_percent > 0) || !(bank_copartner_intrest > 0)))
            {
                is_valid = false;
                validation_errors.Add("درصد و سود بانکی را تعیین نماپید");
            }
            return is_valid;
        }

        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Insert(0, new GridColumn { name = nameof(amount), Text = "مبلغ" });
            list.Insert(1, new GridColumn { name = nameof(bank_copartner_id), Text = "ایدی شریک", visible = false });
            list.Insert(2, new GridColumn { name = nameof(bank_copartner_name), Text = "شریک" });
            list.Insert(0, new GridColumn { name = nameof(bank_copartner_intrest), Text = "سهم شراکت" });
            list.Insert(1, new GridColumn { name = nameof(bank_copartner_percent), Text = "سود بانکی" });
            list.Insert(2, new GridColumn { name = nameof(buyer_name), Text = "سرمایه گذار" });
            list.Insert(0, new GridColumn { name = nameof(buyer_id), Text = "ایدی خریدار", visible = false });
            list.Insert(3, new GridColumn { name = nameof(id), Text = "ایدی", visible = false });
            return list;
        }

        //public override async Task<HsborsResponse<bool>> Delete(long id)
        //{
        //    var hsbors_server = new HsborsResponse<bool>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.delete_purchase, id);
        //    return hsbors_server;

        //}
        //public override async Task<HsborsResponse<Purchase>> Get<Purchase>(string id)
        //{
        //    var hsbors_server = new HsborsResponse<Purchase>();
        //    await hsbors_server.RequestServer(HsborsApiUrl.get_purchase, null, id);
        //    return hsbors_server;
        //}

        public override Task<HsborsResponse<T>> Edit<T>()
        {
            throw new NotImplementedException();
        }
    }

    public class Setting : ListSearchEntity
    {
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("نوع")]
        [Editable]
        public string type { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("کلید")]
        [Editable]
        public string key { get; set; }
        [Required(ErrorMessage = Constants.MessageText.RequiredFieldErrorDynamic), DisplayName("مقدار")]
        [Editable]
        public string value { get; set; }
        //other
        public string type_name { get => type?.GetEnumDesc<SettingType>(); }

        public async override Task<HsborsResponse<T>> Add<T>()
        {
            var hsbors_server = new HsborsResponse<T>();
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                [nameof(this.type)] = type,
                [nameof(this.key)] = key,
                [nameof(this.value)] = value
            };
            await hsbors_server.RequestServer(HsborsApiUrl.add_setting, user);
            return hsbors_server;
        }

        public Setting()
        {
            search_by_filter_api = HsborsApiUrl.search_setting_by_filters;
            edit_api = HsborsApiUrl.edit_setting;
            delete_api = HsborsApiUrl.delete_setting;
            get_api = HsborsApiUrl.get_setting;
        }
        public enum SettingType
        {
            [Description("سود سالانه")]
            AnnualProfit
        }
        public override List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Add(new GridColumn { name = nameof(type_name), Text = "نوع" });
            list.Add(new GridColumn { name = nameof(key), Text = "عنوان" });
            list.Add(new GridColumn { name = nameof(value), Text = "مقدار" });
            list.Add(new GridColumn { name = nameof(id), Text = "ایدی", visible = false });
            return list;
        }

    }

}
