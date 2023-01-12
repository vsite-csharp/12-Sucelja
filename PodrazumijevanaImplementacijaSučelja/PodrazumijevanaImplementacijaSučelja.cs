using System.Security.Claims;

namespace Vsite.CSharp.Sučelja
{
    internal class PodrazumijevanaImplementacijaSučelja
    {
        public interface IHodajući
        {
            void Hodaj();
        }
        // TODO:060 U IPlivajući dodati implementaciju metode Plivaj tako da ispiše "On bi i plivo!".
        public interface IPlivajući
        {
            void Plivaj()
            {
                Console.WriteLine("On bi i plivao!");
            }
        }
        // :061 Deklarirati da klasa osoba implementira sučelje IPlivajući.
        public class Osoba : IHodajući, IPlivajući
        {
            public Osoba(string ime)
            {
                Ime = ime;
            }

            public readonly string Ime;

            public void Hodaj()
            {
                Console.WriteLine($"{Ime} hoda");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var osoba = new Osoba("Slaviša");
            osoba.Hodaj();
            // TODO:062 Pozvati na osobi metodu Plivaj. Što treba napraviti da bi se ona doista pozvala.
            ((IPlivajući)osoba).Plivaj();
            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}