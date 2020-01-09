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
            int rezultat = Prezime.CompareTo(other.Prezime);
            if (rezultat == 0)
                rezultat = Ime.CompareTo(other.Ime);
            return rezultat;
            //if(Prezime == other.Prezime)
            //{
            //    return string.Compare(Ime,other.Ime);
            //}
            //return string.Compare(Prezime, other.Prezime);
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
