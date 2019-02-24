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

            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Первое число: " + firstValue);

            double secondValue = Convert.ToDouble(Console.ReadLine()); // либо double.Parse
            Console.WriteLine("Второе число: " + secondValue);

            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел равно " + result);
        }
    }
}
