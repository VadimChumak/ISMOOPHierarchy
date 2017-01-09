using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ISMOOPHierarchy
{
    public class Paiments
    {
        private Client client;
        private Admin admin;
        private Ordering ordering;
        public Paiments()
        {
            Account acc = new Account("1986522317SZ", 1234.789);
            KK card = new KK("1976-1111-7989-1522", 3505.0, true);
            client = new Client("Petro", "Petrov", card, acc);
            admin = new Admin("Ivan", "Ivanov");
            ordering = new Ordering();
        }
        public void Menu()
        {
            int cay = -1;
            while (cay != 0)
            {
                Console.Clear();
                Console.WriteLine("1.Оплатити замовлення");
                Console.WriteLine("2.Перевести гроші на інший рахунок");
                Console.WriteLine("3.Заблокувати кредитну карту");
                Console.WriteLine("4.Анулювати рахунок");
                cay = int.Parse(Console.ReadLine());
                switch (cay)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Тип замовлення : ");
                        string title = Console.ReadLine();
                        Console.Write("Вартість замовлення : ");
                        double mon = double.Parse(Console.ReadLine());
                        ordering = new Ordering(title, mon);
                        if (client.POrder(client.Card, ordering)) Console.WriteLine("Оплата пройшла успішео");
                        else Console.WriteLine("Не вдалося здійснити оплату. Перевірте баланс карти!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        KK new_card;
                        Console.Write("Номер карти : ");
                        string num = Console.ReadLine();
                        new_card = new KK(num, 0.0, true);
                        Console.Write("Сума , яку необхідно відправити : ");
                        double money = double.Parse(Console.ReadLine());
                        if (client.SendToCard(new_card, money)) Console.WriteLine("Операція пройшла успішно");
                        else Console.WriteLine("Помилка виконання операції. Перевірте баланс карти!");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        client.BlockCard();
                        Console.WriteLine("Кредитну карту з номером " +client.Card.Num +" заблоковано");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Поточна сума на рахунку {0} : {1}", client.Acc.Num, client.Acc.Money);
                        Console.Write("Анулювати рахунок?(Так-Y/Ні-N)");
                        string str = Console.ReadLine();
                        if (str == "Y")
                        {
                            client.Acc.ResetMoney();
                            Console.WriteLine("Рахунок анульовано!");
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
