using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7FinishTask
{
    class Order<TDelivery> : Delivery where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public void DisplayProducts<TProducts>() where TProducts : Product  // Выбор продуктов
        {
            Product.ChooseProduct();
            Console.WriteLine("В вашей корзине {0} лампочек и {1} выключателей", Product.showamB, Product.showamS); //Вывод сколько продуктов выбрал покупатель в итоге

        }

        public void DisplayAddress()
        {
            Console.WriteLine(Address); // вывод адреса
            Console.WriteLine(Delivery.Name); // вывод имени
            Console.WriteLine(Delivery.CurrentDate); // вывод даты доставки
        }
    }
}
