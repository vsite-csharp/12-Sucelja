using System.Reflection.Metadata.Ecma335;

namespace Vsite.CSharp.Sučelja
{
    class SmisaoSučelja
    {
        static void Ispiši(List<Osoba> list)
        {
            foreach (Osoba o in list)
            {
                Console.WriteLine(o);
            }
        }

        public static void SortiranoPoNečemu(List<Osoba> osobe)
        {
            osobe.Sort();
        }

        class UsporediOsobePoImenu : IComparer<Osoba>
        {
            public int Compare(Osoba? x, Osoba? y)
            {
               return string.Compare(x!.Ime, y!.Ime);
            }
        }

        public static void SortiranoPoImenu(List<Osoba> osobe)
        {
            // :010 Koristeći preopterećenu inačicu metode List<T>.Sort(IComparer<T>) abecedno sortirati osobe prema njihovim imenima.
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1
            osobe.Sort(new UsporediOsobePoImenu());
        }

        public static void SortiranoPoDatumuRođenja(List<Osoba> osobe)
        {
            // :011 Koristeći preopterećenu inačicu metode List<T>.Sort(Comparison<T>) sortirati osobe prema njihovim datumima rođenja.
            // https://docs.microsoft.com/en-us/dotnet/api/system.comparison-1
            osobe.Sort((osobaA, osobaB) => osobaA.DatumRođenja.CompareTo(osobaB.DatumRođenja));
        }

        public static void SortiranoPoMjestuRođenja(List<Osoba> osobe)
        {
            // :012 Koristeći preopterećenu inačicu metode List<T>.Sort(Comparison<T>) osobe sortirati prema njihovim mjestima rođenja.
            osobe.Sort((osobaA, osobaB) =>string.Compare(osobaA.MjestoRođenja, osobaB.MjestoRođenja));

        }

        // :013 Pokrenuti program i provjeriti ispise.

        // TODO:014 Pokrenuti i provjeriti testove (3 testa u grupi "SmisaoSučelja" moraju proći)

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", "Marić", new DateTime(1975, 7, 12), "Split"));
            popisOsoba.Add(new Osoba("Žarko", "Lević", new DateTime(1965, 12, 4), "Osijek"));
            popisOsoba.Add(new Osoba("Marko", "Karamatić", new DateTime(1983, 4, 2), "Sinj"));
            popisOsoba.Add(new Osoba("Tomislav", "Kralj", new DateTime(1971, 11, 5), "Beli Manastir"));

            Console.WriteLine("Ispis prije sortiranja:");
            Ispiši(popisOsoba);
            Console.WriteLine();

            try
            {
                Console.WriteLine("Sortiramo podrazumijevano:");
                SortiranoPoNečemu(popisOsoba);
                Ispiši(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po imenu:");
                SortiranoPoImenu(popisOsoba);
                Ispiši(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po datumu rođenja:");
                SortiranoPoDatumuRođenja(popisOsoba);
                Ispiši(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po mjestu rođenja:");
                SortiranoPoMjestuRođenja(popisOsoba);
                Ispiši(popisOsoba);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
