using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class KK:IMoney , ICloneable , IComparable<KK>
    {
        private string card_number;
        private double money;
        private bool is_active;
        public KK(string num, double money , bool active)
        {
            card_number = num;
            this.money = money;
            is_active = active;
        }
        public KK()
            : this("000000000", 0.0 , true)
        {
        }
        public int CompareTo(KK k)
        {
            int res = this.is_active.CompareTo(k.is_active);
            if (res == 0)
            {
                int rez = this.money.CompareTo(k.money);
                if (rez == 0)
                {
                    return this.Num.CompareTo(k.Num);
                }
                else return rez;
            }
            else return res;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void PrintInfo()
        {
            Console.WriteLine("Номер карти : {0}", card_number);
            Console.WriteLine("Баланс карти : {0}",money);
            if (is_active == true) Console.WriteLine("Карта активна");
            else Console.WriteLine("Карта заблокована");
        }
        public string Num
        {
            get
            {
                return card_number;
            }
        }
        public double Money
        {
            get
            {
                return money;
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
        public bool RemoveCard()
        {
            is_active = false;
            return true;
        }
    }
}
