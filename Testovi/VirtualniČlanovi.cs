using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class VirtualniČlanovi
    {
        [TestMethod]
        public void BaznaVirtualnaMetodaVraćaTekst()
        {
            Sučelja.VirtualniČlanovi.ISučelje s = (Sučelja.VirtualniČlanovi.ISučelje)(new Sučelja.VirtualniČlanovi.Bazna());
            Assert.AreEqual("Bazna.VirtualnaMetoda", s.VirtualnaMetoda());
        }

        [TestMethod]
        public void BaznaNevirtualnaMetodaVraćaTekst()
        {
            Sučelja.VirtualniČlanovi.ISučelje s = (Sučelja.VirtualniČlanovi.ISučelje)(new Sučelja.VirtualniČlanovi.Bazna());
            Assert.AreEqual("Bazna.NevirtualnaMetoda", s.NevirtualnaMetoda());
        }

        [TestMethod]
        public void IzvedenaVirtualnaMetodaVraćaTekst()
        {
            Sučelja.VirtualniČlanovi.ISučelje s = (Sučelja.VirtualniČlanovi.ISučelje)(new Sučelja.VirtualniČlanovi.Izvedena());
            Assert.AreEqual("Izvedena.VirtualnaMetoda", s.VirtualnaMetoda());
        }

        [TestMethod]
        public void IzvedenaNevirtualnaMetodaVraćaTekst()
        {
            Sučelja.VirtualniČlanovi.ISučelje s = (Sučelja.VirtualniČlanovi.ISučelje)(new Sučelja.VirtualniČlanovi.Izvedena());
            Assert.AreEqual("Bazna.NevirtualnaMetoda", s.NevirtualnaMetoda());
        }
    }
}
