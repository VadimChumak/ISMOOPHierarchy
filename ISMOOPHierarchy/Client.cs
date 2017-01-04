using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Client:Person , IPersonInfo
    {
        KK card;
        Account acc;
        public Client()
            : base()
        {
            card=new KK("000" , 0.0 , true);
            acc=new Account("000" , 0.0);
        }
        public Client(string name, string lastname ,KK k , Account acc)
            : base(name, lastname)
        {
            card = k;
            this.acc = acc;
        }
        public Account Acc
        {
            get
            {
                return acc;
            }
        }
        public KK Card
        {
            get
            {
                return card;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Lastname
        {
            set
            {
                lastname = value;
            }
            get
            {
                return lastname;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про Клієнта---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
        public bool POrder(KK card , Ordering ord)
        {
            if (ord.PayOrder(card)) return true;
            else return false;
        }
        public void BlockCard()
        {
            card.RemoveCard();
        }
        public bool SendToCard(KK c , double mone)
        {
            if (card.GetMoney(mone)) { c.AddMoney(mone); return true; }
            else return false;
        }
    }
}
