using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBorsWinApp
{
    public class FundDashboard
    {
        public string fund_name { get; set; }
        public long unit_issue_cost { get; set; }
        public long capital_value { get; set; }
        public int interest_rate { get; set; }
        public int balanced_profit_average_percent { get; set; }
        public long profit { get; set; }

        public List<GridColumn> GetGridColumns()
        {
            List<GridColumn> list = new List<GridColumn>();
            list.Insert(0, new GridColumn { name = nameof(fund_name), Text = "نام صندوق" });
            list.Insert(1, new GridColumn { name = nameof(unit_issue_cost), Text = "هزینه خرید واحدهای صندوق" });
            list.Insert(2, new GridColumn { name = nameof(capital_value), Text = "ارزش سرمایه صندوق" });
            list.Insert(3, new GridColumn { name = nameof(balanced_profit_average_percent), Text = "میانگین درصد سود موزون صندوق" });
            list.Insert(4, new GridColumn { name = nameof(profit), Text = "میزان سود صندوق" });
 
            return list;
        }
    }
}
