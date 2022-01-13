using System;
using System.Collections.Generic;

namespace Vsite.CSharp.Sučelja
{
    public class UsporediOsobePoImenu : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            return x.Ime.CompareTo(y.Ime);
        }
    }

    public class UsporediOsobePoDatumuRodenja : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            return x.DatumRođenja.CompareTo(y.DatumRođenja);
        }
    }

    public class UsporediOsobePoMjestuRodenja : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            return x.MjestoRođenja.CompareTo(y.MjestoRođenja);
        }
    }

    class SmisaoSučelja
    {
        static void Ispiši(List<Osoba> list)
        {
            foreach (Osoba o in list)
                Console.WriteLine(o);
        }

        public static void SortiranoPoNečemu(List<Osoba> osobe)
        {
            osobe.Sort();
        }

        public static void SortiranoPoImenu(List<Osoba> osobe)
        {
            // Koristeći preopterećenu inačicu metode List<T>.Sort(IComparer<T>) abecedno sortirati osobe prema njihovim imenima.
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1
            osobe.Sort(new UsporediOsobePoImenu());

        }

        public static void SortiranoPoDatumuRođenja(List<Osoba> osobe)
        {
            //  Koristeći preopterećenu inačicu metode List<T>.Sort(Comparison<T>) sortirati osobe prema njihovim datumima rođenja.
            // https://docs.microsoft.com/en-us/dotnet/api/system.comparison-1
            osobe.Sort(new UsporediOsobePoDatumuRodenja());

        }

        public static void SortiranoPoMjestuRođenja(List<Osoba> osobe)
        {
            //  Koristeći preopterećenu inačicu metode List<T>.Sort(Comparison<T>) osobe sortirati prema njihovim mjestima rođenja.
            osobe.Sort(new UsporediOsobePoMjestuRodenja());

        }

        //  Pokrenuti program i provjeriti ispise.

        // Pokrenuti i provjeriti testove (3 testa u grupi "SmisaoSučelja" moraju proći)

        static void Main(string[] args)
        {
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

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
