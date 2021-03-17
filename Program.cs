using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            string name;

            Console.WriteLine("Добро пожаловать в консольное приложение");
            Console.WriteLine("Введите свое имя:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите свой возраст: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число от 3 до 9");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(name + " я проанализировал твой возраст и могу заявит:");
            if (age(a) == 1)
            {
                Console.WriteLine("Твой возраст - это четное число");
            }
            else
            {
                Console.WriteLine("Твой возраст - это нечетное число");
            }

            if (func(a, b) == 1)
            {
                Console.WriteLine("Квадратный корень полученный из твоего возраста, делится на " + b);
            }
            else
            {
                Console.WriteLine("Квадратный корень полученный из твоего вохраста, не делится на " + b);
            }
            Console.ReadKey();
        }
        public static int age(int x)
        {
            if (x % 2 == 0)
                return 1;
            else
            {
                return 0;
            }
        }
        public static double func(double x, double y)
        {
            x = Math.Sqrt(x);
            x = Math.Ceiling(x);
            if (x % y == 0)
                return 1;
            else
            {
                return 0;
            }
        }
    }
}
