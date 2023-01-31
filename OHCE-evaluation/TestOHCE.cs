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
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on entre un palindrome ALORS il est renvoyé ET le <bienDit> de cette langue est envoyé")]
        public void TestChainePalindromeLangue()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue
            //QUAND on entre un palindrome
            string chaineMirroir = ohce.Mirroir("kayak", Langue.En);
            //ALORS il est renvoyé ET le <bienDit> de cette langue est envoyé
            Assert.Contains("kayak", chaineMirroir);
            Assert.Contains("Well said", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une chaîne ALORS <bonjour> de cette langue est envoyé avant tout")]
        public void TestChaineBonjourLangue()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En);
            //ALORS <bonjour> de cette langue est envoyé avant tout
            Assert.StartsWith("Hello", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue est envoyé en dernier")]
        public void TestChaineAuRevoirLangue()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En);
            //ALORS <auRevoir> dans cette langue est envoyé en dernier
            Assert.EndsWith("Goodbye", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <salutation> de cette langue à cette période est envoyé avant tout CAS {‘matin’, ‘bonjour_am’}")]
        public void TestChaineBonjourLanguePeriodeMatin()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.Matin);
            //ALORS <salutation> de cette langue à cette période est envoyé avant tout
            Assert.StartsWith("Good morning", chaineMirroir);



        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <salutation> de cette langue à cette période est envoyé avant tout CAS {‘après-midi’, ‘bonjour_pm’}")]
        public void TestChaineBonjourLanguePeriodeApresMidi()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.ApresMidi);
            //ALORS <salutation> de cette langue à cette période est envoyé avant tout
            Assert.StartsWith("Good afternoon", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <salutation> de cette langue à cette période est envoyé avant tout CAS {‘soir’, ‘bonjour_soir’}")]
        public void TestChaineBonjourLanguePeriodeSoir()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.Soir);
            //ALORS <salutation> de cette langue à cette période est envoyé avant tout
            Assert.StartsWith("Good evening", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <salutation> de cette langue à cette période est envoyé avant tout CAS {‘nuit’, ‘bonjour_nuit’}")]
        public void TestChaineBonjourLanguePeriodeNuit()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.Nuit);
            //ALORS <salutation> de cette langue à cette période est envoyé avant tout
            Assert.StartsWith("Good night", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier CAS {‘matin’, ‘auRevoir_am’}")]
        public void TestChaineAuRevoirLanguePeriodeMatin()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.Matin);
            //ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier
            Assert.EndsWith("Good morning", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier CAS {‘après-midi’, ‘auRevoir_pm’}")]
        public void TestChaineAuRevoirLanguePeriodeApresMidi()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.ApresMidi);
            //ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier
            Assert.EndsWith("Good afternoon", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier CAS {‘soirée’, ‘auRevoir_soir’}")]
        public void TestChaineAuRevoirLanguePeriodeSoir()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.Soir);
            //ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier
            Assert.EndsWith("Good evening", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier CAS {‘nuit’, ‘auRevoir_nuit’}")]
        public void TestChaineAuRevoirLanguePeriodeNuit()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période>
            //QUAND on saisit une chaîne
            string chaineMirroir = ohce.Mirroir("une chaine d'entrée", Langue.En, Periode.Nuit);
            //ALORS <auRevoir> dans cette langue à cette période est envoyé en dernier
            Assert.EndsWith("Good night", chaineMirroir);
        }


    }
}