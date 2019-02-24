using System;

/*1)Написать программу, вычисляющую среднее арифметическое двух чисел*/

namespace MyProjectDZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 1");
            Console.WriteLine("Введите два числа:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число: " + a);

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: " + b);

            double result = (double)(a + b) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел равно " + result);
        }
    }
}
