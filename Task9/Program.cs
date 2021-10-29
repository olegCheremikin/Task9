using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Введите первое число:");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("не число:");
            }
            Console.WriteLine("Введите второе число:");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("не число:");
            }
            Console.WriteLine("Введите номер операции: 1 - Сложение 2 - Вычитание 3 - Умножение 4 - Деление");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("Результат: {0}", x + y);
                    break;
                case 2:
                    Console.WriteLine("Результат: {0}", x - y);
                    break;
                case 3:
                    Console.WriteLine("Результат: {0}", x * y);
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Результат: {0}", x / y);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Ошибка! Деление на 0!");
                    }
                    break;
                default:
                    Console.WriteLine("Операция выбрана не верно!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
