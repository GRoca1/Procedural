using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diviseur
{
    class Program
    {
        static void Main(string[] args)
        {

            long divis, nbr, n, compt = 0;
            bool Est_premier;

            int Compteur = 0;
            string chaine = "";
            long somme = 1;
            string continuer = "oui";
        
            do
            {
                divis = 2;
                Est_premier = true;

                Console.Write("Veuillez saisir un nombre entier: ");
                nbr = Int64.Parse(Console.ReadLine());
                do
                {
                    if (nbr % divis == 0)
                    {
                        Est_premier = false;
                        chaine += divis + " \t";
                        somme += divis;
                        Compteur++;
                    }

                    divis++;
                }
                while ((divis < nbr));
                if (Est_premier == true)
                {
                    Console.WriteLine("Nombre est premier, il n'a pas de diviseur");

                }
                else
                {
                    Console.WriteLine("Ce n'est pas un nombre premier il a: " + Compteur + " diviseurs du nombre saisi sont:" + chaine);
                    Console.WriteLine(somme);
                }
                Console.WriteLine("Souhaitez vous continuer?(oui/non)");
                continuer = Console.ReadLine();

            } while (continuer == "oui");
            Console.WriteLine("Programme terminé");
            Console.ReadKey();
        }
    }
}
