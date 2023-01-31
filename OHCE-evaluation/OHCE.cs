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
            string auRevoir;
            switch (langue)
            {
                case Langue.En:

                    switch (periode)
                    {
                        case Periode.Matin:
                            salutationPeriode = "Good morning";
                            auRevoir = "Good morning";
                            break;
                        case Periode.ApresMidi:
                            salutationPeriode = "Good afternoon";
                            auRevoir = "Good afternoon";
                            break;
                        case Periode.Soir:
                            salutationPeriode = "Good evening";
                            auRevoir = "Good evening";
                            break;
                        case Periode.Nuit:
                            salutationPeriode = "Good night";
                            auRevoir = "Good night";
                            break;
                        default:
                            salutationPeriode = "Good morning";
                            auRevoir = "Good morning";
                            break;
                    }
                    break;
                case Langue.Fr:
                    switch (periode)
                    {
                        case Periode.Matin:
                            salutationPeriode = "Bonjour";
                            auRevoir = "Au revoir";
                            break;
                        case Periode.ApresMidi:
                            salutationPeriode = "Bon après-midi";
                            auRevoir = "Au revoir";
                            break;
                        case Periode.Soir:
                            salutationPeriode = "Bonsoir";
                            auRevoir = "Au revoir";
                            break;
                        case Periode.Nuit:
                            salutationPeriode = "Bonne nuit";
                            auRevoir = "Au revoir";
                            break;
                        default:
                            salutationPeriode = "Bonjour";
                            auRevoir = "Au revoir";
                            break;
                    }
                    break;
                default:
                    switch (periode)
                    {
                        case Periode.Matin:
                            salutationPeriode = "Bonjour";
                            auRevoir = "Au revoir";
                            break;
                        case Periode.ApresMidi:
                            salutationPeriode = "Bon après-midi";
                            auRevoir = "Au revoir";
                            break;
                        case Periode.Soir:
                            salutationPeriode = "Bonsoir";
                            auRevoir = "Au revoir";
                            break;
                        case Periode.Nuit:
                            salutationPeriode = "Bonne nuit";
                            auRevoir = "Au revoir";
                            break;
                        default:
                            salutationPeriode = "Bonjour";
                            auRevoir = "Au revoir";
                            break;
                    }
                    break;

            }
            string bienDit;

            string chaineMirroir = new string(chaine.Reverse().ToArray());
            switch (langue)
            {
                case Langue.Fr:
                    bienDit = "Bien dit";

                    break;
                case Langue.En:
                    bienDit = "Well said";


                    break; ;
                default:
                    bienDit = "Bien dit";

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
