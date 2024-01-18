namespace Vsite.CSharp.Sučelja
{
    class ImplicitnaEksplicitnaPretvorba
    {
        // 040 Pogledati definicije sučelja IHodajući i IPlivajući te definiciju klase Osoba.
        public interface IHodajući
        {
            void Hodaj();
        }
        public interface IPlivajući
        {
            void Plivaj();
        }
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
            public void Plivaj()
            {
                Console.WriteLine($"{Ime} pliva");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var osobe = new List<Osoba> { new Osoba("Mirko"), new Osoba("Slavko"), new Osoba("Jure") };

            Console.WriteLine("Prošećite se!");
            ProšećiSve(osobe);

            Console.WriteLine("\nRazgibajte se!");
            RazgibajSve(osobe);

            Console.WriteLine("\nGOTOVO!!!");
        }

        // 041 Pogledati definicije donje dvije metode i zaključiti što će se ispisati pokretanjem programa.
        // 042 Pokrenuti program i provjeriti ispis. Obrazložiti zašto se u drugoj metodi ne poziva metoda Plivaj.
        public static void ProšećiSve(IEnumerable<IHodajući> osobe)
        {
            foreach (var o in osobe)
            {
                o.Hodaj();
            }
        }

        // 043 Napraviti neophodne promjene da bi se u donjoj metodi pozvala metoda Plivaj.
        public static void RazgibajSve<T>(IEnumerable<T> osobe)
        {
            foreach (var o in osobe)
            {
                (o as IHodajući)?.Hodaj();
                (o as IPlivajući)?.Plivaj();
            }
        }

        // 044 Pokrenuti i provjeriti testove (dva testa u grupi "ImplicitnaEksplicitnaPretvorba" moraju proći).
    }
}
