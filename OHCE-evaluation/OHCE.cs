using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE_evaluation
{
    internal class OHCE
    {
        public string Mirroir(string chaine)
        {
            string chaineMirroir = new string(chaine.Reverse().ToArray());
            if (chaine == chaineMirroir)
            {
                return "Bonjour " + chaineMirroir + " Bien dit Au revoir";
            }
            else
            {
                return "Bonjour " + chaineMirroir + " Au revoir";
            }

        }

        public string Mirroir(string chaine, Langue langue)
        {
            string bienDit;
            string bonjour;
            string auRevoir;
            string chaineMirroir = new string(chaine.Reverse().ToArray());
            switch (langue)
            {
                case Langue.Fr:
                    bienDit = "Bien dit";
                    bonjour = "Bonjour";
                    auRevoir = "Au revoir";
                    break;
                case Langue.En:
                    bienDit = "Well said";
                    bonjour = "Hello";
                    auRevoir = "Goodbye";
                    break;
                default:
                    bienDit = "Bien dit";
                    bonjour = "Bonjour";
                    auRevoir = "Au revoir";
                    break;

            }
            if (chaineMirroir == chaine)
            {
                return bonjour + " " + chaineMirroir + " " + bienDit + " " + auRevoir;
            }
            else
            {
                return bonjour + " " + chaineMirroir + " " + auRevoir;
            }





        }
    }
}
