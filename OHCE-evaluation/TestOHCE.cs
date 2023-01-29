namespace OHCE_evaluation
{
    public class TestOHCE
    {
        [Fact(DisplayName = "QUAND on saisit une chaine ALORS celle-ci est renvoyé en miroir")]
        public void TestChaineMiroir()

        {
            OHCE ohce = new OHCE();
            //QUAND on sait une chaine
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée");
            //ALORS celle-ci est renvoyé en mirroir
            Assert.Contains("eértne'd eniahc enu", chaineMirroir);
        }
        [Fact(DisplayName = "QUAND on saisit un palindrome ALORS celui-ci est renvoyé ET « Bien dit » est envoyé ensuite")]
        public void TestChainePalindrome()
        {
            OHCE ohce = new OHCE();
            //QUAND on saisit un palindrome
            string chaineMirroir = ohce.Mirroir("kayak");
            //ALORS celui-ci est renvoyé ET « Bien dit » est envoyé ensuite
            Assert.Contains("kayak", chaineMirroir);
            Assert.Contains("Bien dit", chaineMirroir);


        }
        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS « Bonjour » est envoyé avant toute réponse")]
        public void TestChaineBonjour()
        {
            OHCE ohce = new OHCE();
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée");
            //ALORS « Bonjour » est envoyé avant toute réponse
            Assert.StartsWith("Bonjour", chaineMirroir);
        }
        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS « Au revoir » est envoyé en dernier")]
        public void TestChaineAuRevoir()
        {
            OHCE ohce = new OHCE();
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée");
            //ALORS « Au revoir » est envoyé en dernier
            Assert.EndsWith("Au revoir", chaineMirroir);
        }
    }
}