using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Ordering:ICloneable , IComparable<Ordering>
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
        public int CompareTo(Ordering o)
        {
            int res = this.OrderPay.CompareTo(o.OrderPay);
            if (res == 0) return this.OrderTitle.CompareTo(o.OrderTitle);
            else return res;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Print()
        {
            Console.WriteLine("Назва замовлення : {0}", order_title);
            Console.WriteLine("Вартість замовлення  : {0}", sum_money);
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
                if (value >= 0)
                    sum_money = value;
                else sum_money = 0;
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
