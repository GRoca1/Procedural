using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmEnMiles
{
    class Program
    {
        static void Main(string[] args)
        {
                Start:

            {
                Console.WriteLine("Saisissez une valeur en kilomètres:");
                double kilometres = Convert.ToDouble(Console.ReadLine());

                double miles = kilometres / 1.609;

                Console.WriteLine("La conversion en miles est:");
                Console.WriteLine(miles + " Miles");

                
            }
                Console.WriteLine("Voulez-vous continuer(O/N)?");
                ConsoleKeyInfo saisie = Console.ReadKey(true);
            if (saisie.Key == ConsoleKey.O)
            {              
                Console.ReadKey();
                goto Start;
            }
            
            
            

            
        }

        
    }
}
