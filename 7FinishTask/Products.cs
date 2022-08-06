using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7FinishTask
{
    class Bulb : Product // класс описывающий лампочки
    {
        const int twenty = 60; // константа - цена 
        const int fourty = 80;
        public int amount { get; set; }
        public int sum { get; set; }
        public int total { get; set; }
        public void ChoosePower() // выбор мощности 
        {
            Console.WriteLine("Выберите мощность лампочки:\n1. 20 Ватт\n2. 40 Ватт");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        ChooseAmount();
                        Sum(twenty, amount);
                        Console.WriteLine("В корзине {0} лампочки мощностью 20 Ватт. Общая стоимость {1} ед.", amount, sum);
                        OneMore();
                        break;
                    }
                case 2:
                    {
                        ChooseAmount();
                        Sum(fourty, amount);
                        Console.WriteLine("В корзине {0} лампочки мощностью 40 Ватт. Общая стоимость {1} ед.", amount, sum);
                        OneMore();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите верный номер");
                        ChoosePower();
                        break;
                    }
            }
        }

        public override int ChooseAmount() // выбор количества
        {
            Console.WriteLine("Введите нужное количество лампочек");
            amount = int.Parse(Console.ReadLine());
            return amount;
        }

        public override int Sum(int power, int amount) // подсчет суммы
        {
            sum = amount * power;
            return sum;
        }

        public override void OneMore() // выбор других лампочек
        {
            Console.WriteLine("Хотите добавить другие лампочки? Да/Нет");
            string answer = Console.ReadLine();
            if (answer == "Да")
            {
                ChoosePower();
            }
            else
            {
                total = amount;
                ChooseProduct();
            }
        }
    }

    class Switcher : Product // класс описывающий выключатели
    {
        const int black = 150; // константа - цена выключателей
        const int white = 100;
        public int amount { get; set; }
        public int sum { get; set; }

        public int total { get; set; }
        public void ChooseColor() // выбор цвета
        {
            Console.WriteLine("Выберите цвет выключателя:\n1. Черный\n2. Белый");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        ChooseAmount();
                        Sum(black, amount);
                        Console.WriteLine("В корзине {0} выключателя черного цвета. Общая стоимость {1} ед.", amount, sum);
                        OneMore();
                        break;
                    }
                case 2:
                    {
                        ChooseAmount();
                        Sum(white, amount);
                        Console.WriteLine("В корзине {0} выключателя белого цвета. Общая стоимость {1} ед.", amount, sum);
                        OneMore();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите верный номер");
                        ChooseColor();
                        break;
                    }
            }

        }

        public override int ChooseAmount() // выбор количества
        {
            Console.WriteLine("Введите нужное количество товара");
            amount = int.Parse(Console.ReadLine());
            return amount;
        }

        public override int Sum(int color, int amount) // подсчет цены
        {
            sum = amount * color;
            return sum;
        }

        public override void OneMore() // выбор других выключателей
        {
            Console.WriteLine("Хотите добавить другие лампочки? Да/Нет");
            string answer = Console.ReadLine();
            if (answer == "Да")
            {
                ChooseColor();
            }
            else
            {
                total = amount;
                ChooseProduct();
            }
        }

    }

    abstract class Product //абстрактный класс, описывающий лампочки и выключатели
    {
        public static int showamB { get; set; } // общее количество лампочек в корзине
        public static int showamS { get; set; } // общее кол-во выключателей в корзине
        public static void ChooseProduct()
        {
            Console.WriteLine("Выберите продукт из списка: \n1. Лампочка\n2. Выключатель\n3. Закончить выбор");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Bulb bulb = new Bulb();
                        bulb.ChoosePower();
                        showamB = bulb.amount;
                        break;
                    }
                case 2:
                    {
                        Switcher switcher = new Switcher();
                        switcher.ChooseColor();
                        showamS = switcher.amount;
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }
        public abstract int ChooseAmount();

        public abstract int Sum(int a, int b);

        public abstract void OneMore();

    }
}
