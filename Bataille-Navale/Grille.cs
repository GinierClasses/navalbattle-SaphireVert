using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class Grille
    {

        //public List<Case> Cases { get; set; }
        List<Case> Case1 = new List<Case>();
        public Grille(int hauteurGr, int largeurGr)
        {
            
            for(int i = 0; i < hauteurGr; i++)
            {
                for (int j = 0; j < largeurGr; j++)
                {
                    Case1.Add(new Case() { x = i, y = j });
                }
            }
        }

        public Case GetCase(int x, int y)
        {
            
            return Case1.First(c => c.x == x && c.y == y);
            
        }
    }

}
