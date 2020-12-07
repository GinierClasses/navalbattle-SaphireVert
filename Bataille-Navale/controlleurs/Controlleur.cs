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

        public Controlleur() { }

        public void test()
        {
            Grille testGrille = creationGrille(10, 10, true);
        }

        public void creationGrille(int hauteurGr, int largeurGr, bool is_Player)
        {
            if (is_Player)
            {

                 Grille grille = new Grille(new Coordonnée(hauteurGr, largeurGr));
            }
            else
            {
                return user2Grille = new Grille(hauteurGr, largeurGr);
            }
            //Grille userGrille = new Grille();
        }
        
        public Grille creationGrilleOrdi()
        {
            Grille foo = new Grille(10,10);
            return foo;
        }

        public casesNavire validationNavires(string nomNavire, Grille grille, int cordX_dep, int cordY_dep, int cordX_fin, int cordY_fin)
        {   

            casesNavire navire = new casesNavire(nomNavire, grille, cordX_dep, cordX_fin, cordY_dep, cordY_fin);
            return navire;
        }

        public List<ModelNavire> creationListeNavires()
        {
            List<ModelNavire> cases = new List<ModelNavire>();
            ModelNavire porteAvion = new ModelNavire("Porte-avions", 5);
            cases.Add(porteAvion);
            ModelNavire croiseur = new ModelNavire("Croiseur", 4);
            cases.Add(croiseur);
            ModelNavire contreTorpilleur = new ModelNavire("Contre-torpilleurs", 3);
            cases.Add(contreTorpilleur);
            ModelNavire contreTorpilleur2 = new ModelNavire("Contre-torpilleurs", 3);
            cases.Add(contreTorpilleur2);
            ModelNavire torpilleur = new ModelNavire("Torpilleur", 2);
            cases.Add(torpilleur);

            return cases;
        }

    }
}
