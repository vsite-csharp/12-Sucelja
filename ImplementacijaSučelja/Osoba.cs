using System;

namespace Vsite.CSharp.Sučelja
{
    public class Osoba : IComparable<Osoba>
    {
        public Osoba(string ime, string prezime, DateTime datumRođenja, string mjestoRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
            MjestoRođenja = mjestoRođenja;
        }

        public override string ToString()
        {
            return string.Format($"{Ime} {Prezime}, {DatumRođenja.ToShortDateString()}, {MjestoRođenja}");
        }

        public int CompareTo(Osoba other)
        {
            int rezultat = string.Compare(Prezime, other.Prezime, true);
            if(rezultat == 0)
                rezultat = string.Compare(Ime, other.Ime, true);
            return rezultat;
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
