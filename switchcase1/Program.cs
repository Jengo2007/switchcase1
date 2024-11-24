using System;

namespace switchcase1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number =Convert.ToInt32(Console.ReadLine());
            switch (number) 
            {
                case 1 :
                    Console.WriteLine("Понедельник");
                    break;
                case 2 :
                    Console.WriteLine("Вторник");
                    break;
                case 3 :
                    Console.WriteLine("Среда");
                    break;
                case 4 :
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("субота");
                    break;
                case 7:
                    Console.WriteLine("воскресение");
                    break;
                default:
                    Console.WriteLine("Введите число от 1 до 7");
                    break;
                    
            }
        }
    }
}