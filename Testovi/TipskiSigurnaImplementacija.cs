using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Sučelja.Testovi
{
    [TestClass]
    public class TipskiSigurnaImplementacija : ConsoleTest
    {
        [TestMethod]
        public void UsporedbaDvijuDuljinaVraćaVećeOdNuleAkoJePrvaDuljinaVeća()
        {
            TipskiSigurneImplementacije.Duljina d1 = new TipskiSigurneImplementacije.Duljina(5);
            TipskiSigurneImplementacije.Duljina d2 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Usporedi(d1, d2);
            Assert.IsTrue(cw.GetString().Contains(">"));
        }

        [TestMethod]
        public void UsporedbaDvijuDuljinaVraćaVećeManjeOdNuleAkoJePrvaDuljinaManja()
        {
            TipskiSigurneImplementacije.Duljina d1 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Duljina d2 = new TipskiSigurneImplementacije.Duljina(5);
            TipskiSigurneImplementacije.Usporedi(d1, d2);
            Assert.IsTrue(cw.GetString().Contains("<"));
        }

        [TestMethod]
        public void UsporedbaDvijuDuljinaVraćaNuluAkoJePrvaDuljinaJednakaDrugoj()
        {
            var sučelja = typeof(TipskiSigurneImplementacije.Duljina).GetInterfaces();
            Assert.IsTrue(sučelja.Length > 0);
            Assert.IsNotNull(sučelja.FirstOrDefault(t => t.Name == "IComparable`1" && t.IsGenericType && t.GenericTypeArguments[0].Name == "Duljina"));
            TipskiSigurneImplementacije.Duljina d1 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Duljina d2 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Usporedi(d1, d2);
            Assert.IsTrue(cw.GetString().Contains("="));
        }
    }
}
