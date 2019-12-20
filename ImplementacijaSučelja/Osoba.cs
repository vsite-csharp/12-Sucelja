using System;

namespace Vsite.CSharp.Sučelja
{
    // TODO:001 Dopuniti klasu Osoba tako da implementira sučelje IComparable<Osoba> koje će uspoređivati osobe po prezimenu, a ako osobe imaju isto prezime, onda i po imenu. Pokrenuti program i provjeriti ispis.
    // TODO:002 Pokrenuti testove (test iz grupe "ImplementacijaSučelja" mora proći)
    public class Osoba
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

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
