using System;

namespace Instagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestage oma sünniaasta.");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            if(YearOfBirth > 2008)
            {
                Console.WriteLine("Olete liiga noor, et luua instagrami kontot");
            }
            else if(YearOfBirth < 2008)
            {
                Console.WriteLine("Olete piisavalt vana et luua instagrami kontot");
            }
            else
            {
                Console.WriteLine("Olete piisavalt vana et luua instagrami kontot");
            }





        }
    }
}
