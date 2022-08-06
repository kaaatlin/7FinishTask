using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7FinishTask
{
    abstract class Delivery
    {
        public static string Address { get; set; }
        public string Name { get; set; }
        public DateTime CurrentDate { get; set; }
        public virtual void SetDate() { }
        public virtual void GetName()
        {
            Console.WriteLine("Введите Ваше имя и фамилию");
            Name = Console.ReadLine();
        }
        public virtual void GetAdress() { }

        public void ChooseDelivery()
        {
            Console.WriteLine("Выберите тип доставки:\n1. На дом\n2. В пункт выдачи\n3. В офис");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    {
                        HomeDelivery home = new HomeDelivery();
                        home.GetName();
                        home.GetAdress();
                        home.SetDate();
                        break;
                    }
                case 2:
                    {
                        PickPointDelivery pickPoint = new PickPointDelivery();
                        pickPoint.GetName();
                        pickPoint.GetAdress();
                        pickPoint.SetDate();
                        break;
                    }
                case 3:
                    {
                        ShopDelivery shop = new ShopDelivery();
                        shop.GetName();
                        shop.GetAdress();
                        shop.SetDate();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите верные числа");
                        break;
                    }
            }
        }
    }

    class HomeDelivery : Delivery
    {
        public override void GetName()
        {
            base.GetName();
        }
        public override void GetAdress()
        {
            Console.WriteLine("Введите Ваш адрес");
            Address = Console.ReadLine();
        }

        public override void SetDate()
        {
            Console.WriteLine("Дата оформления заказа: " + DateTime.Today);
            CurrentDate = DateTime.Today.AddDays(6);
            Console.WriteLine("Дата прдположительной доставки: {0}. Ожидайте! " + CurrentDate);

        }
    }

    class PickPointDelivery : Delivery
    {
        public override void GetName()
        {
            base.GetName();
        }
        public override void GetAdress()
        {
            Console.WriteLine("Выберите ближайший адрес\n1.Кировский завод, д.4");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    {
                        Address = "Кировский завод, д.4";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите верное число");
                        GetAdress();
                        break;
                    }
            }

        }

        public override void SetDate()
        {
            Console.WriteLine("Дата оформления заказа: " + DateTime.Today);
            CurrentDate = DateTime.Today.AddDays(4);
            Console.WriteLine("Дата прдположительной доставки: {0}. Ожидайте!" + CurrentDate);
        }
    }

    class ShopDelivery : Delivery
    {
        public override void GetName()
        {
            base.GetName();
        }
        public override void GetAdress()
        {
            Console.WriteLine("Выберите ближайший офис\n1.Лиговский проспект, д.4");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    {
                        Address = "Лиговский проспект, д.4";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите верное число");
                        GetAdress();
                        break;
                    }
            }
        }

        public override void SetDate()
        {
            Console.WriteLine("Дата оформления заказа: " + DateTime.Today);
            CurrentDate = DateTime.Today.AddDays(2);
            Console.WriteLine("Дата прдположительной доставки: {0}. Ожидайте!" + CurrentDate);
        }
    }
}
