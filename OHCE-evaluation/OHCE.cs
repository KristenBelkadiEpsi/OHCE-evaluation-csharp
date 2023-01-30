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
            string chaineMirroir = new string(chaine.Reverse().ToArray());
            switch (langue)
            {
                case Langue.Fr:
                    bienDit = "Bien dit";
                    break;
                case Langue.En:
                    bienDit = "Well said";
                    break;
                default:
                    bienDit = "Bien dit";
                    break;

            }
            if (chaineMirroir == chaine)
            {
                return "Bonjour " + chaineMirroir + " " + bienDit + " " + "Au revoir";
            }
            else
            {
                return "Bonjour " + chaineMirroir + " " + "Au revoir";
            }





        }
    }
}
