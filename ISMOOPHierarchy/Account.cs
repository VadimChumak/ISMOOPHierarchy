using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Account:IMoney , ICloneable , IComparable<Account>
    {
        private string account_number;
        private double money;
        public Account(string num, double money)
        {
            account_number = num;
            this.money = money;
        }
        public object Clone()
        {
            return new Account(this.Num, this.Money);
        }
        public Account()
            : this("000000000", 0.0)
        {
        }
        public int CompareTo(Account a)
        {
            if (this.Money > a.Money) return 1;
            else if (this.Money < a.Money) return -1;
            else
            {
                return this.account_number.CompareTo(a.account_number);
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Номер рахунку : {0}", account_number);
            Console.WriteLine("Баланс рахунку : {0}" , money);
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
