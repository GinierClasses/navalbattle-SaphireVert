using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class Grille
    {

        public Coordonnée CordMax;
        public List<ModelNavire> NaviresGrille = new List<ModelNavire>(); 

        public Grille(Coordonnée cordMax)
        {
            this.CordMax = cordMax;
        }

        public Case GetCase(int x, int y)
        {
            return Case1.First(c => c.x == x && c.y == y);   
        }
    }

}
