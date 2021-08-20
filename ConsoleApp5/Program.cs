using System;
using System.Collections.Generic;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<string> Imenik = new();
           


            do
            {
                Console.WriteLine("Unesite novo ime");
                string unos = Console.ReadLine();
                if (unos == "q")
                {
                    break;
                }
            } while (true);
            foreach (string ime in Imenik)
            {
                Console.WriteLine(ime);
            }

            
        }
    }
}
