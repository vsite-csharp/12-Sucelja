using System;
using System.Reflection.Metadata.Ecma335;

namespace Vsite.CSharp.Sučelja
{
    // TODO:001 Dopuniti klasu Osoba tako da implementira sučelje IComparable<Osoba> koje će uspoređivati osobe po prezimenu, a ako osobe imaju isto prezime, onda i po imenu. Pokrenuti program i provjeriti ispis.
    // TODO:002 Pokrenuti testove (test iz grupe "ImplementacijaSučelja" mora proći)
    public class Osoba:IComparable<Osoba>
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
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

        public int CompareTo(Osoba? other)
        {
            int compare = string.Compare(Prezime,other?.Prezime,true);
            if(compare == 0) { compare = string.Compare(Ime, other?.Ime, true); }
            return compare;
        }
        
        
    }
}
