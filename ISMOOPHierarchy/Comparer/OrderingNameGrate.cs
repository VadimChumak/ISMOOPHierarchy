using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Comparer
{
    class OrderingNameGrate:IComparer<Ordering>
    {
        public int Compare(Ordering a, Ordering b)
        {
            if (a.OrderTitle.CompareTo(b.OrderTitle)==1) return -1;
            else if (a.OrderTitle.CompareTo(b.OrderTitle)==-1) return 1;
            else return 0;
        }
    }
    class OrderingNameLess : IComparer<Ordering>
    {
        public int Compare(Ordering a, Ordering b)
        {
            if (a.OrderTitle.CompareTo(b.OrderTitle) == 1) return 1;
            else if (a.OrderTitle.CompareTo(b.OrderTitle) == -1) return -1;
            else return 0;
        }
    }
    class OrderingMoneyGrate : IComparer<Ordering>
    {
        public int Compare(Ordering a, Ordering b)
        {
            if (a.OrderPay.CompareTo(b.OrderPay) == 1) return -1;
            else if (a.OrderPay.CompareTo(b.OrderPay) == -1) return 1;
            else return 0;
        }
    }
    class OrderingMoneyLess : IComparer<Ordering>
    {
        public int Compare(Ordering a, Ordering b)
        {
            if (a.OrderPay.CompareTo(b.OrderPay) == 1) return 1;
            else if (a.OrderPay.CompareTo(b.OrderPay) == -1) return -11;
            else return 0;
        }
    }

}
