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
            string langue = "en";
            //QUAND on entre un palindrome
            string chaineMirroir = ohce.Mirroir("kayak", langue);
            //ALORS il est renvoy� ET le <bienDit> de cette langue est envoy�
            Assert.Contains("kayak", chaineMirroir);
            Assert.Contains("Well said", chaineMirroir);
        }

    }
}