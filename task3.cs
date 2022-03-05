using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir eded daxil edin: ");
            double number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                while (number > 1)
                {
                    number /= 2;
                }
                if (number == 1)
                {
                    Console.WriteLine("quvvetidir");
                }
                else if (number != 1)
                {
                    Console.WriteLine("quvveti deyil");
                }
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("cut eded daxil edin:");
                
            }
        }
    }
}
