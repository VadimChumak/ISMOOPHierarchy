using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Account:IMoney
    {
        private string account_number;
        private double money;
        public Account(string num, double money)
        {
            account_number = num;
            this.money = money;
        }
        public Account()
            : this("000000000", 0.0)
        {
        }
        public double Money
        {
            get
            {
                return money;
            }
        }
        public string Num
        {
            get
            {
                return account_number;
            }
        }
        public bool AddMoney(double sum)
        {
            money += sum;
            return true;
        }
        public void ResetMoney()
        {
            money = 0;
        }
        public bool GetMoney(double sum)
        {
            if (sum > money) return false;
            else
            {
                money -= sum;
                return true;
            }
        }
    }
}
