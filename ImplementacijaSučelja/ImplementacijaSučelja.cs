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
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                //  Pokrenuti program i provjeriti ispis.
                var osobe = new List<Osoba>();
                osobe.Add(new Osoba("Ante", "Žagar", new DateTime(1975, 12, 5), "Split"));
                osobe.Add(new Osoba("Pero", "Perić", new DateTime(1984, 7, 21), "Osijek"));
                osobe.Add(new Osoba("Ante", "Perić", new DateTime(1992, 3, 17), "Beli Manastir"));
                osobe.Add(new Osoba("Ante", "Babaja", new DateTime(1989, 9, 25), "Sinj"));
                osobe.Add(new Osoba("Darko", "Ćuk", new DateTime(1993, 10, 2), "Benkovac"));
                osobe.Add(new Osoba("Marko", "Čorluka", new DateTime(1975, 4, 12), "Pazin"));
                Ispiši(osobe);

                Console.WriteLine("SORTIRANO:");
                osobe.Sort();
                Ispiši(osobe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
 
            Console.WriteLine("\nGOTOVO!!!");
        }

        static void Ispiši<T>(IEnumerable<T> obilaziv)
        {
            foreach (var e in obilaziv)
            { 
                Console.WriteLine(e);
            }
        }
    }
}
