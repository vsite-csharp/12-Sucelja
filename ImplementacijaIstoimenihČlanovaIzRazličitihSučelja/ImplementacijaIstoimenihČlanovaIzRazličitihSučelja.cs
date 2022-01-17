using System;

namespace Vsite.CSharp.Sučelja
{
    class ImplementacijaIstoimenihČlanovaIzRazličitihSučelja
    {
        public interface ISkokUvis
        {
            void Skoči();

            
        }

        public interface ISkokUdalj
        {
            void Skoči();
        }

        // :050 U implementaciju metode Skoči u klasi Desetobojac napisati naredbu koja će ispisati "Hop". U metodi Main pozvati tu metodu, pokrenuti program i provjeriti ispis.

        // :051 Definirati da klasa Desetobojac implementira sučelje ISkokUvis. U implementaciji metode tog sučelja treba ispisati "Hop u vis".
        // :052 U metodi Main dodati naredbu koja će pozvati metodu Skoči iz sučelja ISkokUVis. Pokrenuti program i provjeriti ispise.

        // :053 Definirati da klasa Desetobojac implementira sučelje ISkokUDalj.U implementaciji metode tog sučelja treba ispisati "Hop u dalj".
        // :054 U metodi Main dodati naredbu koja će pozvati metodu Skoči iz sučelja ISkokUdalj. Pokrenuti program i provjeriti ispise.
        public class Desetobojac : ISkokUvis, ISkokUdalj
        {
            void ISkokUvis.Skoči()
            {
                Console.WriteLine("Hop u vis");
            }

            void ISkokUdalj.Skoči()
            {
                Console.WriteLine("Hop u dalj");
            }
            public void Skoči()
            {
                Console.WriteLine("Hop");
            }
        }

        // :055 Pokrenuti i provjeriti testove (3 testa u grupi "ImplementacijeIstoimenihČlanovaRazličitihSučelja" moraju proći).

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Desetobojac db = new Desetobojac();
            ((ISkokUvis) db).Skoči();
            ((ISkokUdalj) db).Skoči();


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
