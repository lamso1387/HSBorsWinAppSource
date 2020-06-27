using HBorsWinApp.CombinedControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBorsWinApp
{
    public class CachedData
    {
        public static Dictionary<long, string> funds = new Dictionary<long, string>();

        public static List<Account> accounts = new List<Account>();



        public static async Task CacheFunds()
        {
            var fund = new Fund();
            var response = await fund.Search<Fund, SearchFundRequest>(new SearchFundRequest());
            Dictionary<long, string> new_funds = new Dictionary<long, string>();
            foreach (var item in response.Model)
            {
                new_funds[item.id] = item.name;
            }
            funds = new_funds;
        }
        public static async Task CacheAccounts()
        {
            var account = new Account();
            var response = await account.Search<Account, SearchAccountRequest>(new SearchAccountRequest());
            accounts = response.Model;
        }
    }
    public class Constants
    {
        public static LoadingUC main_loader = null;

        public static LoadingUC form_loader_loading
        {
            get { return formLoaderLoading; }
            set
            {
                if (value == null) { formLoaderLoading = form_previous_loader_loading; }
                else
                {
                    form_previous_loader_loading = formLoaderLoading;
                    formLoaderLoading = value;
                }

            }
        }
        private static LoadingUC formLoaderLoading = null;
        private static LoadingUC form_previous_loader_loading = null;

        public class MessageText
        {
            public const string DefaultLoader = "در حال انجام عملیات ...";
            public const string DefaultLoaderGettingData = "در حال دریافت اطلاعات ...";
            public const string DefaultLoaderAppOperation = "در حال اجرا ...";
            public const string InternavServerError = "";
            public const string NoContent = "موردی یافت نشد";
            public const string EmptyWarn = "هشدار تنظیم نشد";
            public const string RequiredFieldError = "فیلد اجباری تکمیل نشده است";
            public const string RangeFieldError = "مقدار وارد شده معتبر نیست";
            public const string DefaultAdding = "در حال ذخیره اطلاعات ...";
            public const string DefaultAddOk = "اطلاعات با موفیت ذخیره شد.";
            public const string DefaultDGVEmpty = "حداقل یک ردیف در لیست اضافه کنید";
            public const string RequiredFieldErrorDynamic = "فیلد  {0} تکمیل نشده است";
            public const string RangeFieldErrorDynamic = "فیلد {0} را بطور صحیح وارد نمائید";
            public const string HSDateFormatErrorDynamic = "نوع فرمت تاریخ فیلد {0} اشتباه است";
            public const string MobileFormatError = "فرمت موبایل اشتباه است";
            public const string DefaultDeleting = "در حال حذف ...";
            public const string DefaultDeleteOk = "اطلاعات با موفقیت حذف شد";
            public const string LoadFormEditData = "در حال بازیابی اطلاعات ...";
            public const string UpdateCancel = "تغییری انجام نشد";
            public const string DefaultEditing = "در حال بروزرسانی ...";
            public const string InternetConnectionError = "اتصال به اینترنت و سرور را بررسی کنید";
            public const string DefaultDashboardGettingData = "در حال ساخت داشبورد...";
            public const string RestrictionViolation = "انجام عملیات بعلت محدودیت مجاز نیست";
            public const string PendingChanges = "ابتدا تغییرات قبلی باید ذخیره یا لغو شود";
            public const string PurcheseAmountSumError= "جمع مبالغ سرمایه گذاران باید برابر مبلغ سرمایه گذاری باشد";

            public static string RequiredFieldErrorMes(string field) => $"{RequiredFieldError}: {field}";
            public static string DefaultDGVEmptyMes(string entity) => $"{DefaultDGVEmpty}: {entity}";
            public static string RestrictionViolationMes(string object_) => $"{RestrictionViolation}: {object_}";
            public static string PendingChangesMes(string object_) => $"{PendingChanges}: {object_}";
        }
    }
}
