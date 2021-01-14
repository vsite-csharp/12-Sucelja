﻿using System;

namespace Vsite.CSharp.Sučelja
{
    class VirtualniČlanovi
    {
        public interface ISučelje
        {
            string NevirtualnaMetoda();
            string VirtualnaMetoda();
        }

        // Definirati klasu Bazna tako da implementira sučelje ISučelje. Metoda NevirtualnaMetoda neka vraća "Bazna.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Bazna.VirtualnaMetoda".
        public class Bazna :ISučelje
        {
            public string NevirtualnaMetoda()
        }
            return

        // TODO:031 Definirati klasu Izvedena da je izvedena iz klase Bazna te u klasi Izvedena implementirati metode iz ISučelja. Metoda NevirtualnaMetoda neka vraća "Izvedena.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Izvedena.VirtualnaMetoda".
        // TODO:032 Provjeriti poruke o pogreškama ili upozorenja prevoditelja.
        public class Izvedena : Bazna
        {
        

        public new string NevirtualnaMetoda()
        {
            return "Izvedena"
        }

        public static void PozoviVirtualnuMetodu(ISučelje sučelje)
        {
            Console.WriteLine(sučelje.VirtualnaMetoda());
        }

        static void Main(string[] args)
        {
                // TODO:033 Inicijalizirati objekt instancom klase Bazna te provjeriti ispis
            ISučelje s1 = new Bazna();
            PozoviNevirtualnuMetodu(s1);
            PozoviVirtualnuMetodu(s1);

            // TODO:034 Inicijalizirati objekt instancom klase Izvedena te provjeriti ispis
            ISučelje s2 = null;
            PozoviNevirtualnuMetodu(s2);
            PozoviVirtualnuMetodu(s2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        // TODO:035 Pokrenuti i provjeriti testove (4 testa u grupi "VirtualniČlanovi" moraju proći).
    }
}
