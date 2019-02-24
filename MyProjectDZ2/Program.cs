using System;


/*2)Введите три числа и вывилите на экран значение суммы и произведения этих чисел*/

namespace MyProjectDZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 2");

            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3");
            thirdValue = double.Parse(Console.ReadLine());


            double sumResult = firstValue + secondValue + thirdValue;
            double multRezult = firstValue * secondValue * thirdValue;
            Console.WriteLine("Сумма введеных трех чисел равна " + sumResult + ", а произведение равно " + multRezult);
        }
    }
}
