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
    }
}