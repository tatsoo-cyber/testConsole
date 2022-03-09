/**
 * jeu du nombre caché 
 * author : tatsoo
 * date : 19/02/2022
 */
using System;


namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int valeur = 0, essai = 0, nbre = 1;
            bool correct = false;
            // saisie du nombre à chercher 
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saississez un nombre entier");
                }
            }
            Console.Clear();
            //saisie du premier essai
            correct = false;
             while (!correct)
             {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
             }                     
            //boucle sur les essais            
            while (essai != valeur) 
            {
                // test de l'essai par rapport à la valeur chercher
                if (essai > valeur)
                {
                    Console.WriteLine("--> trop grand !");
                }
                else
                {
                    Console.WriteLine("--> trop petit !");
                }
                // saisie d'un nouvel essai 
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez un essai = ");
                        essai = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie: saisissez un nombre entier");
                    }
                }                
                //compteur d'essais 
                nbre++;
            }
            // valeur trouvé 
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();

        }
    }
}
