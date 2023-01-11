namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class ImplementacijaSučelja
    {
        [TestMethod]
        public void SortiranjeOsobaPoPrezimenuIImenu()
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba("Ante", "Žagar", new DateTime(1975, 12, 5), "Split"));
            osobe.Add(new Osoba("Pero", "Perić", new DateTime(1984, 7, 21), "Osijek"));
            osobe.Add(new Osoba("Ante", "Perić", new DateTime(1992, 3, 17), "Beli Manastir"));
            osobe.Add(new Osoba("Ante", "Babaja", new DateTime(1989, 9, 25), "Sinj"));
            osobe.Sort();
            Assert.AreEqual("Babaja", osobe[0].Prezime);
            Assert.AreEqual("Perić", osobe[1].Prezime);
            Assert.AreEqual("Ante", osobe[1].Ime);
            Assert.AreEqual("Perić", osobe[2].Prezime);
            Assert.AreEqual("Pero", osobe[2].Ime);
            Assert.AreEqual("Žagar", osobe[3].Prezime);
        }
    }
}
