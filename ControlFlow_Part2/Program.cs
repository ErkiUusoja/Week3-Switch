using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisustatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234,
            //programm kuvab konsoolis "Tere tulemast!
            //kui sisustatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti"

            Console.WriteLine("Plaun sisestage PIN-kood");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if(userPIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }




        }
    }
}
