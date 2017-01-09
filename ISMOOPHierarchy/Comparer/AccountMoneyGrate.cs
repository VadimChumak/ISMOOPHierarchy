using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Comparer
{
    class AccountMoneyGrate:IComparer<Account>
    {
        public int Compare(Account a, Account b)
        {
            if (a.Money.CompareTo(b.Money) == 1) return -1;
            else if (a.Money.CompareTo(b.Money) == -1) return 1;
            else return 0;
        }
    }
    class AccountMoneyLess : IComparer<Account>
    {
        public int Compare(Account a, Account b)
        {
            if (a.Money.CompareTo(b.Money) == 1) return 1;
            else if (a.Money.CompareTo(b.Money) == -1) return -1;
            else return 0;
        }
    }
    class AccountNumberGrate : IComparer<Account>
    {
        public int Compare(Account a, Account b)
        {
            if (a.Num.CompareTo(b.Num) == 1) return -1;
            else if (a.Num.CompareTo(b.Num) == -1) return 1;
            else return 0;
        }
    }
    class AccountNumberLess : IComparer<Account>
    {
        public int Compare(Account a, Account b)
        {
            if (a.Num.CompareTo(b.Num) == 1) return 1;
            else if (a.Num.CompareTo(b.Num) == -1) return -1;
            else return 0;
        }
    }
}
