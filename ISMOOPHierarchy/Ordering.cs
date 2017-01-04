using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Ordering
    {
        private string order_title;
        private double sum_money;
        public Ordering(string str, double mon)
        {
            order_title = str;
            sum_money = mon;
        }
        public Ordering()
            : this("Unknown", 0.0)
        {
        }
        public string OrderTitle
        {
            get
            {
                return order_title;
            }
            set
            {
                order_title = value;
            }
        }
        public double OrderPay
        {
            set
            {
                sum_money = value;
            }
            get
            {
                return sum_money;
            }
        }
        public bool PayOrder(KK card)
        {
            card.GetMoney(sum_money);
            return true;
        }
    }
}
