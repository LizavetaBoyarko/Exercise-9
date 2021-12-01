using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует калькулятор!");
            int x=0;
            int y=0;
            try
            {
                Console.Write("Введите целое число. X= ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y= ");
                y = Convert.ToInt32(Console.ReadLine());
                
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                Console.ReadKey();
            }
            Console.WriteLine("Введите код операции");
            Console.WriteLine("1-сложение");
            Console.WriteLine("2-вычитание");
            Console.WriteLine("3-произведение");
            Console.WriteLine("4-частное");
            int Sum = 0;
            int Sub = 0;
            int Mult = 0;
            int Div = 0;
            try
            {
                Console.Write("Ваш выбор: ");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Результат:{0}", Sum = x + y);
                        break;
                    case 2:
                        Sub = x - y;
                        Console.WriteLine("Результат:{0}", Sub);
                        break;
                    case 3:
                        Mult = x * y;
                        Console.WriteLine("Результат:{0}", Mult);
                        break;
                    case 4:
                        try
                        {
                            Div = x / y;
                            Console.WriteLine("Результат:{0}", Div);
                        }
                        catch when (y==0)
                        {
                            Console.WriteLine("Ошибка! Попытка деления на ноль");
                        }
                        break;
                    default:
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                }
            }        
             catch
            {
                    Console.WriteLine("Завершение программы");
            }
            Console.ReadKey();

        }
            
    }  
}
