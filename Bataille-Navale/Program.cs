using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            Grille grille1 = new Grille();
            Console.WriteLine(grille1.GetCase(7, 5).x);
            Console.WriteLine(grille1.GetCase(7, 5).y);
            //Console.WriteLine(grille1.GetCase(7, 5).navire.name);



        }
    }

}
