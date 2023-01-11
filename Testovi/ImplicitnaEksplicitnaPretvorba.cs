using OsobaHP = Vsite.CSharp.Sučelja.ImplicitnaEksplicitnaPretvorba.Osoba;

namespace Vsite.CSharp.Sučelja.Testovi
{

    [TestClass]
    public class ImplicitnaEksplicitnaPretvorba : ConsoleTest
    {
        [TestMethod]
        public void OsobaImplementiraSučeljaIHodajućiIPlivajući()
        {
            var interfaces = typeof(OsobaHP).GetInterfaces();
            Assert.IsTrue(interfaces.Contains(typeof(Vsite.CSharp.Sučelja.ImplicitnaEksplicitnaPretvorba.IHodajući)));
            Assert.IsTrue(interfaces.Contains(typeof(Vsite.CSharp.Sučelja.ImplicitnaEksplicitnaPretvorba.IPlivajući)));
        }

        [TestMethod]
        public void RazgibajSveProšećeIRasplivaSve()
        {
            var osobe = new List<OsobaHP> { new OsobaHP("Mirko"), new OsobaHP("Slavko"), new OsobaHP("Jure") };
            Sučelja.ImplicitnaEksplicitnaPretvorba.RazgibajSve(osobe);
            Assert.AreEqual(6, cw?.Count);
            Assert.AreEqual("Mirko hoda", cw?.GetString());
            Assert.AreEqual("Mirko pliva", cw?.GetString());
            Assert.AreEqual("Slavko hoda", cw?.GetString());
            Assert.AreEqual("Slavko pliva", cw?.GetString());
            Assert.AreEqual("Jure hoda", cw?.GetString());
            Assert.AreEqual("Jure pliva", cw?.GetString());
        }
    }
}
