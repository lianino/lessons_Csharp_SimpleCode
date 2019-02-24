using System;

namespace MyProjectDZ3

/* 3)Простой конвертер любой валюты*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 3");
            Console.WriteLine("Конвертор рубли в доллары:");
            double RUB = Convert.ToDouble(Console.ReadLine());
            double result = RUB / 65.46;
            Console.WriteLine(RUB + " руб - " + result.ToString("#.##") + "$");
        }
    }
}
