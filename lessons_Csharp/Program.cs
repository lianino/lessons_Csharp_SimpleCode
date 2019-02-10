using System;


namespace lessons_Csharp
{
    class Program
    {
        /*1)Написать программу, вычисляющую среднее арифметическое двух чисел
          2)Введите три числа и вывилите на экран значение суммы и произведения этих чисел
          3)Простой конвертер любой валюты
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 1");
            Console.WriteLine("Введите два числа:");
           
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число: " + a);

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: " + b);

            double result =(double) (a + b) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел равно " + result);

            Console.WriteLine();
            Console.WriteLine("Домашнее задание 2");
            Console.WriteLine("Введите три числа:");

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число: " + a);

            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: " + b);

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье число: " + c);

            int result2 = a + b + c;
            int result3 = a * b * c;
            Console.WriteLine("Сумма введеных трех чисел равна " + result2 + ", а произведение равно " + result3);

            Console.WriteLine();
            Console.WriteLine("Домашнее задание 3");
            Console.WriteLine("Конвертор рубли в доллары:");
            double RUB = Convert.ToDouble(Console.ReadLine());
            result = RUB/65.46;
            Console.WriteLine(RUB + "руб - " + result.ToString("#.##") + "$" );

        }
    }
}

