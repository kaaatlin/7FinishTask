using System;

namespace _7FinishTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order<Delivery> order = new Order<Delivery>();

            order.DisplayProducts<Product>(); //Выбор продуктов

            order.ChooseDelivery(); // Выбор способа доставки
        }
    }
}
