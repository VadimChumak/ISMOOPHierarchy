using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Comparer
{
    class KKMoneyGrate:IComparer<KK>
    {
        public int Compare(KK a, KK b)
        {
            if (a.Money.CompareTo(b.Money) == 1) return -1;
            else if (a.Money.CompareTo(b.Money) == -1) return 1;
            else return 0;
        }
    }
    class KKMoneyLess : IComparer<KK>
    {
        public int Compare(KK a, KK b)
        {
            if (a.Money.CompareTo(b.Money) == 1) return 1;
            else if (a.Money.CompareTo(b.Money) == -1) return -1;
            else return 0;
        }
    }
    class KKNumberGrate : IComparer<KK>
    {
        public int Compare(KK a, KK b)
        {
            if (a.Num.CompareTo(b.Num) == 1) return -1;
            else if (a.Num.CompareTo(b.Num) == -1) return 1;
            else return 0;
        }
    }
    class KKNumberLess : IComparer<KK>
    {
        public int Compare(KK a, KK b)
        {
            if (a.Num.CompareTo(b.Num) == 1) return 1;
            else if (a.Num.CompareTo(b.Num) == -1) return -1;
            else return 0;
        }
    }
}
