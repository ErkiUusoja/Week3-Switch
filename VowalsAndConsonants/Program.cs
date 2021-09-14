using System;

namespace VowalsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib, kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui sisestatud täht on täishälik - programm kuvab
            //"täishäälik"
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälik"
            //kasutame Switch'i

            Console.WriteLine("sisesta täht");
            char usercharacter = Convert.ToChar(Console.ReadLine().ToLower());

            //"mingi sõne" -string
            // 'a' - character ehk char

            switch (usercharacter)
            {
                case 'a':
                    Console.WriteLine("täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("täishäälik");
                    break;
                default:
                    Console.WriteLine("kaashäälik");
                    break;
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
