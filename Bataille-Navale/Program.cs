using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bataille_Navale.controlleurs;

namespace Bataille_Navale
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] tableau =
            {
                { "x", "o", "x", "o", "x" },
                { "o", "x", "o", "x", "o" },
                { "x", "o", "x", "o", "x" },
                { "o", "x", "o", "x", "o" },
                { "x", "o", "x", "o", "x" }
            };

            void afficherCases()
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tableau[i, j]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
            }
            afficherCases();

            int dimensionsGrille = 10;

            Controlleur test = new Controlleur();
            Grille grilleJoueur1 = test.creationGrille(dimensionsGrille, dimensionsGrille, true);

            casesNavire sousmarin1 = test.creationNavire("superSumarinx17", grilleJoueur1, 2,2, 3,5);
            casesNavire sousmarin2 = test.creationNavire("superSumarinx17", grilleJoueur1, 2,5, 3,3);

            Console.WriteLine(sousmarin1.name);
            sousmarin1.cases.ForEach(cas => Console.WriteLine("x: " + cas.x + ", y: " + cas.y));
            Console.WriteLine(grilleJoueur1);

        }
    }

}
