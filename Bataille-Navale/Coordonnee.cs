using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    public class Coordonnee
    {
        public int x { get; set; }
        public int y { get; set; }
        public Coordonnee(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {

            Coordonnee coordonnée = (Coordonnee)obj;
            return coordonnée.x == this.x && coordonnée.y == this.y;
        }
    }
}
