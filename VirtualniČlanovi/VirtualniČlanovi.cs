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

        //:030 Definirati klasu Bazna tako da implementira sučelje ISučelje. Metoda NevirtualnaMetoda neka vraća "Bazna.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Bazna.VirtualnaMetoda".
        public class Bazna : ISučelje
        {
            public string NevirtualnaMetoda()
            {
                return "Bazna.NevirtualnaMetoda";
            }

            public virtual string VirtualnaMetoda()
            {
                return "Bazna.VirtualnaMetoda";
            }
        }

        //:031 Definirati klasu Izvedena da je izvedena iz klase Bazna te u klasi Izvedena implementirati metode iz ISučelja. Metoda NevirtualnaMetoda neka vraća "Izvedena.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Izvedena.VirtualnaMetoda".
        //:032 Provjeriti poruke o pogreškama ili upozorenja prevoditelja.
        public class Izvedena : Bazna, ISučelje
        {

            public string  NevirtualnaMetoda()
            {
                return base.NevirtualnaMetoda();
            }

            public virtual string VirtualnaMetoda()
            {
                return "Izvedena.VirtualnaMetoda";
            }
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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //:033 Inicijalizirati objekt instancom klase Bazna te provjeriti ispis
            ISučelje s1 = new Bazna();
            PozoviNevirtualnuMetodu(s1);
            PozoviVirtualnuMetodu(s1);

            //:034 Inicijalizirati objekt instancom klase Izvedena te provjeriti ispis
            ISučelje s2 = new Izvedena();
            PozoviNevirtualnuMetodu(s2);
            PozoviVirtualnuMetodu(s2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        //:035 Pokrenuti i provjeriti testove (4 testa u grupi "VirtualniČlanovi" moraju proći).
    }
}
