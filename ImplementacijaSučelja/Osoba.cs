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
            int result = Prezime.CompareTo(other.Prezime);
            if (result == 0)
            {
                result = Ime.CompareTo(other.Ime);
            }
            return result;
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
