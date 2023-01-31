using OHCE_evaluation;
using System.Globalization;

DateTime maintenant = System.DateTime.Now;
CultureInfo culture = CultureInfo.CurrentCulture;

Periode periode;
Langue langue;
string entree = "defaut";
switch (maintenant)
{

    case DateTime date when (date.Hour >= 6 && date.Hour < 12):
        periode = Periode.Matin;
        break;
    case DateTime date when (date.Hour >= 12 && date.Hour < 18):

        periode = Periode.ApresMidi;
        break;
    case DateTime date when (date.Hour >= 18 && date.Hour < 22):
        periode = Periode.Soir;
        break;
    case DateTime date when (date.Hour >= 22 && date.Hour < 6):
        periode = Periode.Nuit;
        break;
    default:
        periode = Periode.Matin;
        break;

}
switch (culture.Name)
{
    case "fr-FR":
        langue = Langue.Fr;
        break;
    case "en-US":
        langue = Langue.En;
        break;
    default:
        langue = Langue.Fr;
        break;
}
Console.Write("=> ");
entree = Console.ReadLine();
OHCE ohce = new OHCE();
Console.WriteLine(ohce.Mirroir(entree, langue, periode));
