using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class casesNavire
    {
        public int taille;
        public char direction;
        public string position;

        public casesNavire(int taille, char direction, string position )
        {


            this.taille = taille;
            this.direction = direction;
            this.position = position;
        }
    }
}
