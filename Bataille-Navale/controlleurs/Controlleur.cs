using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale.controlleurs
{
    class Controlleur
    {

        Grille user1Grille;
        Grille user2Grille;

        public Grille creationGrille(int hauteurGr, int largeurGr, bool player1)
        {
            if (player1)
            {
                return user1Grille = new Grille(hauteurGr, largeurGr);
            }
            else
            {
                return user2Grille = new Grille(hauteurGr, largeurGr);
            }
            //Grille userGrille = new Grille();
        }

        public Navire creationNavire(string nomNavire, int cordX_dep, int cordY_dep, int cordX_fin, int cordY_fin)
        {
            
            List<Case> casesNav = new List<Case>();
            for(int i = 0; i <= (cordX_fin-cordX_dep); i++)
            {
                for (int j = 0; j <= (cordY_fin - cordY_dep); j++)
                {
                    casesNav.Add(userGrille.GetCase(i, j));
                }
            }
            Navire navire = new Navire(nomNavire, casesNav);
            return navire;
        }
    }
}
