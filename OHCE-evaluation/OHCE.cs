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
            string chaineMirroir = new string(chaine.Reverse().ToArray());
            switch (langue)
            {
                case Langue.Fr:
                    bienDit = "Bien dit";
                    bonjour = "Bonjour";
                    break;
                case Langue.En:
                    bienDit = "Well said";
                    bonjour = "Hello";
                    break;
                default:
                    bienDit = "Bien dit";
                    bonjour = "Bonjour";
                    break;

            }
            if (chaineMirroir == chaine)
            {
                return bonjour + " " + chaineMirroir + " " + bienDit + " " + "Au revoir";
            }
            else
            {
                return bonjour + " " + chaineMirroir + " " + "Au revoir";
            }





        }
    }
}
