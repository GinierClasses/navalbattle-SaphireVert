using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class Case
    {
        public int x;
        public int y;
        public bool touched;
        //public Navire navire = new Navire("toto", 5, 'V', );
        public Case() { }
        public Case(int x, int y)
        {
            this.touched = false;
            this.x = x;
            this.y = y;
            
        }


    }
}
