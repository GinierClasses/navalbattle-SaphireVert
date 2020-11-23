using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class Navire
    {
        public string name;
        public List<Case> cases;
        public char orientation;

        public Navire(string name, List<Case> cases)
        {
            this.name = name;
            this.cases = cases;
            //this.orientation = orientation;

        }
    }
}
