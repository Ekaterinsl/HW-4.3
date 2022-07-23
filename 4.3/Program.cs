using System;

namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадай число");
            Random random = new Random();
            Console.WriteLine("введите максимальное число");
            int n = int.Parse(Console.ReadLine());
            int inumber = random.Next(1, n);
            string f;

            while (true)
            {
                Console.Write("\nВведите число: ");
               
                {
                    f = Console.ReadLine();

                    if (f == string.Empty)

                    {
                        Console.WriteLine("Загаданное число"+ inumber);

                        break;
                    }

                    if (f != string.Empty)
                    { 
                        int usernumber = int.Parse(f);
                        if (usernumber > inumber)
                        {
                            Console.WriteLine("Загаданное  число меньше");
                        }

                        else if (usernumber < inumber)
                        {
                            Console.WriteLine("Загаданное число больше");
                        }
                       
                        else
                        {
                            Console.WriteLine("Вы угадали число!");
                            break;

                        }
                    }
                }

            }
        }
    }
}
