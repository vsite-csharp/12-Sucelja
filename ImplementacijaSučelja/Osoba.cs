namespace Vsite.CSharp.Sučelja
{
    // :001 Dopuniti klasu Osoba tako da implementira sučelje IComparable<Osoba> koje će uspoređivati osobe po prezimenu, a ako osobe imaju isto prezime, onda i po imenu. Pokrenuti program i provjeriti ispis.
    // :002 Pokrenuti testove (test iz grupe "ImplementacijaSučelja" mora proći)
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

        public int CompareTo(Osoba? other)
        {
            int rezultat = Prezime.CompareTo(other!.Prezime);
            if (rezultat != 0)
                return rezultat;
            return Ime.CompareTo(other.Ime);
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
