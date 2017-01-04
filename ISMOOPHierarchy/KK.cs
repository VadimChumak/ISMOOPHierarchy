using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class KK:IMoney
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
        public string Num
        {
            get
            {
                return card_number;
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
