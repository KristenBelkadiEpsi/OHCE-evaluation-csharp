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
            char[] charArray = chaine.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
