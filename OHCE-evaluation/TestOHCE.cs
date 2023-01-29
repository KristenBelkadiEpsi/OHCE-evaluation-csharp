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
    }
}