using System;

namespace Vsite.CSharp.Sučelja
{
    //  Dopuniti klasu Osoba tako da implementira sučelje IComparable<Osoba> koje će uspoređivati osobe po prezimenu, a ako osobe imaju isto prezime, onda i po imenu. Pokrenuti program i provjeriti ispis.
    //  Pokrenuti testove (test iz grupe "ImplementacijaSučelja" mora proći)
    public class Osoba : IComparable<Osoba>
    {
        public Osoba(string ime, string prezime, DateTime datumRođenja, string mjestoRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
            MjestoRođenja = mjestoRođenja;
        }

        public int CompareTo(Osoba other)
        {
            if (this.Prezime.Equals(other.Prezime))
            {
                return this.Ime.CompareTo(other.Ime);
            }

            return this.Prezime.CompareTo(other.Prezime);
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
