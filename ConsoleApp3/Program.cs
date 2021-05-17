using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Составить программу "КАЛЬКУЛЯТОР", которая после ввода
            //* двух чисел и одного из чисел 1 2 3 4(которые соотвуствуют +,-,*,/)
            //* произойдет вычисления,а результат выдаст на экран.//

            Console.WriteLine("Введите первое число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третие число");
            double z = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            switch (z)
            {
                case 1: c = x + y;break;
                case 2: c = x - y;break;
                case 3: c = x * y; break;
                case 4: c = x / y; break;

                /*дописать*/
                default: Console.WriteLine("Ошибка выбора оператора");break;
            }
            /*Вывести ответ*/
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
