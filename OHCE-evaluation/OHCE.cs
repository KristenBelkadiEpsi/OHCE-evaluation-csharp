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


    }
}
