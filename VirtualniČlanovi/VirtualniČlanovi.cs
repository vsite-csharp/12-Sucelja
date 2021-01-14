using System;

namespace Vsite.CSharp.Sučelja
{
    class VirtualniČlanovi
    {
        public interface ISučelje
        {
            string NevirtualnaMetoda();
            string VirtualnaMetoda();
        }

        //  Definirati klasu Bazna tako da implementira sučelje ISučelje. Metoda NevirtualnaMetoda neka vraća "Bazna.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Bazna.VirtualnaMetoda".
        public class Bazna : ISučelje
        {
            public string NevirtualnaMetoda()
            {
                return "Bazna.NevirtualnaMetoda";
            }
            public string VirtualnaMetoda()
            {
                return "Bazna.VirtualnaMetoda";
            }
        }

        //  Definirati klasu Izvedena da je izvedena iz klase Bazna te u klasi Izvedena implementirati metode iz ISučelja. Metoda NevirtualnaMetoda neka vraća "Izvedena.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Izvedena.VirtualnaMetoda".
        //  Provjeriti poruke o pogreškama ili upozorenja prevoditelja.
        public class Izvedena : Bazna
        {
            public new string NevirtualnaMetoda()
            {
                return "Izvedena.NevirtualnaMetoda";
            }
            //public override string VirtualnaMetoda()
            //{
            //    return "Izvedena.VirtualnaMetoda";
            //}
        }

        public static void PozoviNevirtualnuMetodu(ISučelje sučelje)
        {
            Console.WriteLine(sučelje.NevirtualnaMetoda());
        }

        public static void PozoviVirtualnuMetodu(ISučelje sučelje)
        {
            Console.WriteLine(sučelje.VirtualnaMetoda());
        }

        static void Main(string[] args)
        {
            //  Inicijalizirati objekt instancom klase Bazna te provjeriti ispis
            ISučelje s1 = new Bazna();
            PozoviNevirtualnuMetodu(s1);
            PozoviVirtualnuMetodu(s1);

            // Inicijalizirati objekt instancom klase Izvedena te provjeriti ispis
            ISučelje s2 = new Izvedena();
            PozoviNevirtualnuMetodu(s2);
            PozoviVirtualnuMetodu(s2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        //  Pokrenuti i provjeriti testove (4 testa u grupi "VirtualniČlanovi" moraju proći).
    }
}
