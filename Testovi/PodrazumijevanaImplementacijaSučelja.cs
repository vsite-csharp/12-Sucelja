using OsobaHP = Vsite.CSharp.Sučelja.PodrazumijevanaImplementacijaSučelja.Osoba;

namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class PodrazumijevanaImplementacijaSučelja : ConsoleTest
    {
        [TestMethod]
        public void OsobaImplementiraSučeljaIHodajućiIPlivajući()
        {
            var interfaces = typeof(OsobaHP).GetInterfaces();
            Assert.IsTrue(interfaces.Contains(typeof(Sučelja.PodrazumijevanaImplementacijaSučelja.IHodajući)));
            Assert.IsTrue(interfaces.Contains(typeof(Sučelja.PodrazumijevanaImplementacijaSučelja.IPlivajući)));
        }

        [TestMethod]
        public void OsobaMožeHodatiAliNeIPlivati()
        {
            var osoba = new OsobaHP("Mirko");
            osoba.Hodaj();
            (osoba as Sučelja.PodrazumijevanaImplementacijaSučelja.IPlivajući)?.Plivaj();
            Assert.AreEqual(2, cw?.Count);
            Assert.AreEqual("Mirko hoda", cw?.GetString());
            Assert.AreEqual("On bi i plivo!", cw?.GetString());
        }
    }
}
