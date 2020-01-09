using System;
using static Vsite.CSharp.Sučelja.ImplementacijaIstoimenihČlanovaIzRazličitihSučelja;

namespace Vsite.CSharp.Sučelja
{
    class ImplementacijaIstoimenihČlanovaIzRazličitihSučelja
    {
        public interface ISkokUvis
        {
            void Skoči();
        }

        public interface ISkokUDalj
        {
            void Skoči();
        }



        public class Desetobojac:ISkokUvis,ISkokUDalj
        {
            public void Skoči()
            {
                Console.WriteLine("Hop");
            }

         void ISkokUvis.Skoči()
            {
                Console.WriteLine("Hop u vis");
            }

            void ISkokUDalj.Skoči()
            {
                Console.WriteLine("Hop u dalj");
            }
        }


        static void Main(string[] args)
        {
            Desetobojac db = new Desetobojac();

            db.Skoči();
            ((ISkokUvis)db).Skoči();
            ((ISkokUDalj)db).Skoči();
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
