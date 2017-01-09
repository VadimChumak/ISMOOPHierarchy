using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Extension
{
    public static class OrderingExtension
    {
        public static bool ArePaidUp(this Ordering o)
        {
            if (o.OrderPay > 0) return false;
            else return true;
        }
        public static void ResetOrdering(this Ordering o)
        {
            o.OrderTitle = "";
            o.OrderPay = 0;
        }
    }
}
