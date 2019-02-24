using System;


/*2)Введите три числа и вывилите на экран значение суммы и произведения этих чисел*/

namespace MyProjectDZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 2");
            Console.WriteLine("Введите три числа:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первое число: " + a);

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: " + b);

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье число: " + c);

            int result2 = a + b + c;
            int result3 = a * b * c;
            Console.WriteLine("Сумма введеных трех чисел равна " + result2 + ", а произведение равно " + result3);
        }
    }
}
