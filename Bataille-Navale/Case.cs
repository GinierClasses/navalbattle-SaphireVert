using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class Case
    {
        public Coordonnée position;
        public bool touched;
        public bool occupé;
        //public Navire navire = new Navire("toto", 5, 'V', );
        public Case() { }
        public Case(int x, int y)
        {
            this.touched = false;
            this.position.x = x;
            this.position.y = y;
            
        }


    }
}
