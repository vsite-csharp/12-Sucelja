using System;

namespace Vsite.CSharp.Sučelja
{
    // TODO:002 Pokrenuti testove (test iz grupe "ImplementacijaSučelja" mora proći)
    public class Osoba : IComparable<Osoba>
    {
        public Osoba(string ime, string prezime, DateTime datumRođenja, string mjestoRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
            MjestoRođenja = mjestoRođenja;
        }

        public int CompareTo(Osoba o)
        {
            return Prezime.Equals(o.Prezime) ? Ime.CompareTo(o.Ime) : Prezime.CompareTo(o.Prezime);
        }

        public override string ToString()
        {
            return string.Format($"{Ime} {Prezime}, {DatumRođenja.ToShortDateString()}, {MjestoRođenja}");
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
