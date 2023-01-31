namespace OHCE_evaluation
{
    public class TestOHCE
    {
        [Fact(DisplayName = "QUAND on saisit une chaine ALORS celle-ci est renvoy� en miroir")]
        public void TestChaineMiroir()

        {
            OHCE ohce = new OHCE();
            //QUAND on sait une chaine
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e");
            //ALORS celle-ci est renvoy� en mirroir
            Assert.Contains("e�rtne'd eniahc enu", chaineMirroir);
        }
        [Fact(DisplayName = "QUAND on saisit un palindrome ALORS celui-ci est renvoy� ET ��Bien dit�� est envoy� ensuite")]
        public void TestChainePalindrome()
        {
            OHCE ohce = new OHCE();
            //QUAND on saisit un palindrome
            string chaineMirroir = ohce.Mirroir("kayak");
            //ALORS celui-ci est renvoy� ET ��Bien dit�� est envoy� ensuite
            Assert.Contains("kayak", chaineMirroir);
            Assert.Contains("Bien dit", chaineMirroir);


        }
        [Fact(DisplayName = "QUAND on saisit une cha�ne ALORS ��Bonjour�� est envoy� avant toute r�ponse")]
        public void TestChaineBonjour()
        {
            OHCE ohce = new OHCE();
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e");
            //ALORS ��Bonjour�� est envoy� avant toute r�ponse
            Assert.StartsWith("Bonjour", chaineMirroir);
        }
        [Fact(DisplayName = "QUAND on saisit une cha�ne ALORS ��Au revoir�� est envoy� en dernier")]
        public void TestChaineAuRevoir()
        {
            OHCE ohce = new OHCE();
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e");
            //ALORS ��Au revoir�� est envoy� en dernier
            Assert.EndsWith("Au revoir", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on entre un palindrome ALORS il est renvoy� ET le <bienDit> de cette langue est envoy�")]
        public void TestChainePalindromeLangue()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue
            //QUAND on entre un palindrome
            string chaineMirroir = ohce.Mirroir("kayak", Langue.En);
            //ALORS il est renvoy� ET le <bienDit> de cette langue est envoy�
            Assert.Contains("kayak", chaineMirroir);
            Assert.Contains("Well said", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une cha�ne ALORS <bonjour> de cette langue est envoy� avant tout")]
        public void TestChaineBonjourLangue()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En);
            //ALORS <bonjour> de cette langue est envoy� avant tout
            Assert.StartsWith("Hello", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on saisit une cha�ne ALORS <auRevoir> dans cette langue est envoy� en dernier")]
        public void TestChaineAuRevoirLangue()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En);
            //ALORS <auRevoir> dans cette langue est envoy� en dernier
            Assert.EndsWith("Goodbye", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout CAS {�matin�, �bonjour_am�}")]
        public void TestChaineBonjourLanguePeriodeMatin()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.Matin);
            //ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout
            Assert.StartsWith("Good morning", chaineMirroir);



        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout CAS {�apr�s-midi�, �bonjour_pm�}")]
        public void TestChaineBonjourLanguePeriodeApresMidi()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.ApresMidi);
            //ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout
            Assert.StartsWith("Good afternoon", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout CAS {�soir�, �bonjour_soir�}")]
        public void TestChaineBonjourLanguePeriodeSoir()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.Soir);
            //ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout
            Assert.StartsWith("Good evening", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout CAS {�nuit�, �bonjour_nuit�}")]
        public void TestChaineBonjourLanguePeriodeNuit()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.Nuit);
            //ALORS <salutation> de cette langue � cette p�riode est envoy� avant tout
            Assert.StartsWith("Good night", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier CAS {�matin�, �auRevoir_am�}")]
        public void TestChaineAuRevoirLanguePeriodeMatin()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.Matin);
            //ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier
            Assert.EndsWith("Good morning", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier CAS {�apr�s-midi�, �auRevoir_pm�}")]
        public void TestChaineAuRevoirLanguePeriodeApresMidi()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.ApresMidi);
            //ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier
            Assert.EndsWith("Good afternoon", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier CAS {�soir�e�, �auRevoir_soir�}")]
        public void TestChaineAuRevoirLanguePeriodeSoir()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.Soir);
            //ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier
            Assert.EndsWith("Good evening", chaineMirroir);
        }
        [Fact(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode> QUAND on saisit une cha�ne ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier CAS {�nuit�, �auRevoir_nuit�}")]
        public void TestChaineAuRevoirLanguePeriodeNuit()
        {
            OHCE ohce = new OHCE();
            //ETANT DONNE un utilisateur parlant une langue ET que la p�riode de la journ�e est <p�riode>
            //QUAND on saisit une cha�ne
            string chaineMirroir = ohce.Mirroir("une chaine d'entr�e", Langue.En, Periode.Nuit);
            //ALORS <auRevoir> dans cette langue � cette p�riode est envoy� en dernier
            Assert.EndsWith("Good night", chaineMirroir);
        }


    }
}