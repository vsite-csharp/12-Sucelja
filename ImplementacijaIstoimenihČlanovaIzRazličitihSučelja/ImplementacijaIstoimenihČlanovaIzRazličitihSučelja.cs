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
                Console.WriteLine("Skok!");
            }

            void ISkokUvis.Skoči()
            {
                Console.WriteLine("Skok u vis je'ate!");
            }

            void ISkokUdalj.Skoči()
            {
                Console.WriteLine("Skok u dalj je'enti!");
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
