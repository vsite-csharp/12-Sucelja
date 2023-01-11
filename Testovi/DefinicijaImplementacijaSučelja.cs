namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class DefinicijaImplementacijaSučelja
    {
        [TestMethod]
        public void SvojstvoVraćaZadanuVrijednost()
        {
            IMojeSučelje i = (IMojeSučelje)(new Implementacija());
            i.Svojstvo = "abcd";
            Assert.AreEqual("abcd", i.Svojstvo);
        }

        [TestMethod]
        public void PozivMetodeGeneriraDogađaj()
        {
            IMojeSučelje i = (IMojeSučelje)(new Implementacija());
            događajJeObrađen = false;
            i.MojDogađaj += ObradaDogađaja;
            i.GenerirajMojDogađaj();
            Assert.AreEqual(true, događajJeObrađen);
        }

        void ObradaDogađaja(object sender, EventArgs args)
        {
            događajJeObrađen = true;
        }

        private bool događajJeObrađen = false;
    }
}
