using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet
{

    class Program
    {
        /*fonction pour demander à l'utilisateur de continuer  !! */
        static char controle(string s)
        {
            char c = ' ';
            do
            {
                Console.Write(s);
                c = Console.ReadKey().KeyChar;

            } while (c != 'N' && c != 'O');

            return c;

        }

        static char fonction(int sommeDesPlaces, int achat, int rang, int placeRestante, char carcar, char c)
        {

            if (sommeDesPlaces >= achat)
            {
                // affichage des places !! 
                int h = 0;
                while (h < achat)
                {
                    Console.SetCursorPosition(5 * (h + 1), 10 + rang);
                    Console.Write(c);

                    h++;
                }
                Console.SetCursorPosition(0, 7);


                carcar = controle("voulez vous continuer ? (n/o)");

            }
            else if (placeRestante < achat && placeRestante > 0)
            {
                Console.SetCursorPosition(0, 7);

                Console.Write(" il n 'y 'a pas assez de place sur la rangée " + rang + " place disponible sur la rangée " + placeRestante);

                carcar = controle("voulez vous continuer ? (n/o)");
            }
            else
            {

                Console.SetCursorPosition(0, 7); Console.Write(" Désolé , il n'y a plus de place !!");

                carcar = controle("voulez vous continuer ? (n/o)");
            }



            Console.Clear();
            return carcar;
        }

        static int remplissage(int var1, int[,] tableau, int var2)
        {

            int sommeDesPlaces = 0;
            int k = 0;
            while (k < var1)
            {

                tableau[var2, k] = 1;

                sommeDesPlaces += tableau[var2, k];
                k++;
            }
            return sommeDesPlaces;
        }
        static void Main(string[] args)
        {
            // déclaration des variables !!
            int achat, rang;
            char c = 'x';
            char carcar = ' ';
            //  int sommeDesPlaces = 0;
            int placeRestante = 0;
            // déclaration d'un tableau de 8 lignes et 9 colonnes 
            int[,] tableau = new int[8, 9];

            while (carcar != 'N')
            {



                // nombres de places achetes 
                Console.WriteLine("Combien de places voulez vous acheter ?");
                achat = int.Parse(Console.ReadLine());

                // la rangées dans laquelle  
                Console.WriteLine(" A quelle rangée voulez vous aller  ?");
                rang = int.Parse(Console.ReadLine());

                // affichage de la grille !! 

                Console.SetCursorPosition(0, 8);
                Console.WriteLine("----------------------------------------------------------");
                Console.SetCursorPosition(0, 10);

                Console.WriteLine("0 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("1 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("2 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("3 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("4 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("5 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("6 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("7 | [   ][   ][   ][   ][   ][   ][   ][   ][   ]");
                Console.WriteLine("      0    1    2    3    4    5    6    7     8 ");


                if (rang == 0)
                {
                    int sommeDesPlaces = 0;
                    //   int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                    //
                }
                if (rang == 1)
                {
                    //   remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //    int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }
                if (rang == 2)
                {
                    // remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //    int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }
                if (rang == 3)
                {
                    // remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //  int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }
                if (rang == 4)
                {
                    // remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //  int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }
                if (rang == 5)
                {
                    // remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //  int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }
                if (rang == 6)
                {
                    // remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //  int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }
                if (rang == 7)
                {
                    // remplissage du rang selon le nombre de billets 
                    int sommeDesPlaces = 0;
                    //  int placeRestante = 0;
                    // Nombre de places restantes !! 
                    placeRestante = 9 - remplissage(achat, tableau, rang);
                    carcar = fonction(remplissage(achat, tableau, rang), achat, rang, placeRestante, carcar, c);
                }

            }

            Console.ReadLine();
        }
    }
}
