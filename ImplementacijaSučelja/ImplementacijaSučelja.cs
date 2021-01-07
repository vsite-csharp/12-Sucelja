using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Sučelja
{
    class ImplementacijaSučelja
    {
        static void Main(string[] args)
        {
            try
            {
                //  Pokrenuti program i provjeriti ispis.
                List<Osoba> osobe = new List<Osoba>();
                osobe.Add(new Osoba("Ante", "Žagar", new DateTime(1975, 12, 5), "Split"));
                osobe.Add(new Osoba("Pero", "Perić", new DateTime(1984, 7, 21), "Osijek"));
                osobe.Add(new Osoba("Ante", "Perić", new DateTime(1992, 3, 17), "Beli Manastir"));
                osobe.Add(new Osoba("Ante", "Babaja", new DateTime(1989, 9, 25), "Sinj"));
                Ispiši(osobe);

                Console.WriteLine("SORTIRANO:");
                osobe.Sort();
                Ispiši(osobe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        static void Ispiši<T>(IEnumerable<T> obilaziv)
        {
            foreach (var e in obilaziv)
                Console.WriteLine(e);
        }
    }
}
