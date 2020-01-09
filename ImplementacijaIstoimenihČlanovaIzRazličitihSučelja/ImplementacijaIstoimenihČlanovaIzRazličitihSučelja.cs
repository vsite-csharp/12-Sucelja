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

        public class Desetobojac : ISkokUvis, ISkokUdalj
        {
            public void Skoči()
            {
                Console.WriteLine("Hop");
            }

            void ISkokUvis.Skoči()
            {
                Console.WriteLine("Hop u vis");
            }

            void ISkokUdalj.Skoči()
            {
                Console.WriteLine("Hop u dalj");               
            }        
        }
        
        static void Main(string[] args)
        {
            Desetobojac db = new Desetobojac();
            db.Skoči();
            ((ISkokUvis)db).Skoči();
            ((ISkokUdalj)db).Skoči();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
