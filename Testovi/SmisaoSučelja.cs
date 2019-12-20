using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Collections.Generic;

namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class SmisaoSučelja
    {
        static List<Osoba> PopisOsoba()
        {
            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", "Anić", new DateTime(1975, 7, 12), "Split"));
            popisOsoba.Add(new Osoba("Žarko", "Žarkić", new DateTime(1965, 12, 4), "Osijek"));
            popisOsoba.Add(new Osoba("Marko", "Markić", new DateTime(1983, 4, 2), "Sinj"));
            popisOsoba.Add(new Osoba("Tomislav", "Tomić", new DateTime(1971, 11, 5), "Beli Manastir"));

            return popisOsoba;
        }

        [TestMethod]
        public void SortiranjePoImenu()
        {
            List<Osoba> popisOsoba = PopisOsoba();
            Sučelja.SmisaoSučelja.SortiranoPoImenu(popisOsoba);
            Assert.AreEqual("Ana", popisOsoba[0].Ime);
            Assert.AreEqual("Marko", popisOsoba[1].Ime);
            Assert.AreEqual("Tomislav", popisOsoba[2].Ime);
            Assert.AreEqual("Žarko", popisOsoba[3].Ime);
        }

        [TestMethod]
        public void SortiranjePoDatumuRođenja()
        {
            List<Osoba> popisOsoba = PopisOsoba();
            Sučelja.SmisaoSučelja.SortiranoPoDatumuRođenja(popisOsoba);
            Assert.AreEqual("Žarko", popisOsoba[0].Ime);
            Assert.AreEqual("Tomislav", popisOsoba[1].Ime);
            Assert.AreEqual("Ana", popisOsoba[2].Ime);
            Assert.AreEqual("Marko", popisOsoba[3].Ime);
        }

        [TestMethod]
        public void SortiranjePoMjestuRođenja()
        {
            List<Osoba> popisOsoba = PopisOsoba();
            Sučelja.SmisaoSučelja.SortiranoPoMjestuRođenja(popisOsoba);
            Assert.AreEqual("Tomislav", popisOsoba[0].Ime);
            Assert.AreEqual("Žarko", popisOsoba[1].Ime);
            Assert.AreEqual("Marko", popisOsoba[2].Ime);
            Assert.AreEqual("Ana", popisOsoba[3].Ime);
        }
    }
}
