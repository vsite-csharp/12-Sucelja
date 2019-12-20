using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class ImplementacijeIstoimenihČlanovaRazličitihSučelja : ConsoleTest
    {
        [TestMethod]
        public void SkokUVis()
        {
            ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac d = new ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac();
            ((ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.ISkokUvis)d).Skoči();
            Assert.AreEqual("Hop u vis", cw.GetString());
        }

        [TestMethod]
        public void SkokUDalj()
        {
            ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac d = new ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac();
            ((ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.ISkokUdalj)d).Skoči();
            Assert.AreEqual("Hop u dalj", cw.GetString());
        }

        [TestMethod]
        public void Skoči()
        {
            ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac d = new ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac();
            d.Skoči();
            Assert.AreEqual("Hop", cw.GetString());
        }
    }
}
