using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

        public string Mirroir(string chaine, Langue langue, Periode periode)
        {
            string salutationPeriode;
            switch (langue)
            {
                case Langue.En:

                    switch (periode)
                    {
                        case Periode.Matin:
                            salutationPeriode = "Good morning";
                            break;
                        case Periode.ApresMidi:
                            salutationPeriode = "Good afternoon";
                            break;
                        case Periode.Soir:
                            salutationPeriode = "Good evening";
                            break;
                        case Periode.Nuit:
                            salutationPeriode = "Good night";
                            break;
                        default:
                            salutationPeriode = "Good morning";
                            break;
                    }
                    break;
                case Langue.Fr:
                    switch (periode)
                    {
                        case Periode.Matin:
                            salutationPeriode = "Bonjour";
                            break;
                        case Periode.ApresMidi:
                            salutationPeriode = "Bon après-midi";
                            break;
                        case Periode.Soir:
                            salutationPeriode = "Bonsoir";
                            break;
                        case Periode.Nuit:
                            salutationPeriode = "Bonne nuit";
                            break;
                        default:
                            salutationPeriode = "Bonjour";
                            break;
                    }
                    break;
                default:
                    switch (periode)
                    {
                        case Periode.Matin:
                            salutationPeriode = "Bonjour";
                            break;
                        case Periode.ApresMidi:
                            salutationPeriode = "Bon après-midi";
                            break;
                        case Periode.Soir:
                            salutationPeriode = "Bonsoir";
                            break;
                        case Periode.Nuit:
                            salutationPeriode = "Bonne nuit";
                            break;
                        default:
                            salutationPeriode = "Bonjour";
                            break;
                    }
                    break;

            }
            string bienDit;
            string auRevoir;
            string chaineMirroir = new string(chaine.Reverse().ToArray());
            switch (langue)
            {
                case Langue.Fr:
                    bienDit = "Bien dit";
                    auRevoir = "Au revoir";
                    break;
                case Langue.En:
                    bienDit = "Well said";

                    auRevoir = "Goodbye";
                    break; ;
                default:
                    bienDit = "Bien dit";
                    auRevoir = "Au revoir";
                    break;

            }
            if (chaineMirroir == chaine)
            {
                return salutationPeriode + " " + chaineMirroir + " " + bienDit + " " + auRevoir;
            }
            else
            {
                return salutationPeriode + " " + chaineMirroir + " " + auRevoir;
            }
        }
    }
}
