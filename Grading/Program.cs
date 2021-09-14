using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            int Grade = Convert.ToInt32(Console.ReadLine());

            if (Grade == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            
            if (Grade == 4)
            {
                Console.WriteLine("Väga hea");
            }

            if (Grade == 3)
            {
                Console.WriteLine("Hea");
            }

            if (Grade == 2)
            {
                Console.WriteLine("Rahuldav");
            }

            if (Grade == 1)
            {
                Console.WriteLine("Puudulik");
            }

            else
            {
                Console.WriteLine("Puudulik");
            }



        }
    }
}
