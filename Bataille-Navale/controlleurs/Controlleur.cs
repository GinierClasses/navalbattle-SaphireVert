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

        public Grille creationGrille(int hauteurGr, int largeurGr, bool is_Player)
        {
            if (is_Player)
            {

                return user1Grille = new Grille(new Coordonnee(hauteurGr, largeurGr));
            }
            else
            {
                return user2Grille = new Grille(new Coordonnee(hauteurGr, largeurGr));
            }
            //Grille userGrille = new Grille();
        }
        
        public Grille creationGrilleOrdi()
        {
            Grille foo = new Grille(new Coordonnee(10, 10));
            return foo;
        }

        public Coordonnee PlacementNavire(List<ModelNavire> modelNavire)
        {
            modelNavire = creationListeNavires();
            if ()
            {
                user1Grille.NaviresGrille.Add(modelNavire);
            }
        }

        public casesNavire validationNavires(int taille, char direction, string position)
        {   
            casesNavire navire = new casesNavire(taille, direction, position);
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
