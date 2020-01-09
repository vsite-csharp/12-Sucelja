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

        // TODO:030 Definirati klasu Bazna tako da implementira sučelje ISučelje. Metoda NevirtualnaMetoda neka vraća "Bazna.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Bazna.VirtualnaMetoda".
        public class Bazna : ISučelje // dodano ISucelje
        {
            public string NevirtualnaMetoda()//novo dodano
            {
                return "Bazna.NevirtualnaMetoda";
            }

            public virtual string VirtualnaMetoda()//novo dodano+doadao virtual
            {
                return "Bazna.VirtualnaMetoda";
            }
        }


        // TODO:031 Definirati klasu Izvedena da je izvedena iz klase Bazna te u klasi Izvedena nadglasati (override) metode iz ISučelja. 
        //Metoda NevirtualnaMetoda neka vraća "Izvedena.NevirtualnaMetoda", a VirtualnaMetoda neka vraća "Izvedena.VirtualnaMetoda".
        // TODO:032 Provjeriti poruke o pogreškama ili upozorenja prevoditelja.
        public class Izvedena : Bazna//,ISučelje//dodao :Bazna ISučelje
        {
            public new string NevirtualnaMetoda()//novo dodano
            {
                return "Izvedena.NevirtualnaMetoda";
            }

            public override string VirtualnaMetoda()//novo dodano
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
            // TODO:033 Inicijalizirati objekt instancom klase Bazna te provjeriti ispis
            ISučelje s1 = new Bazna();// umjesto  null;
            PozoviNevirtualnuMetodu(s1);
            PozoviVirtualnuMetodu(s1);

            // TODO:034 Inicijalizirati objekt instancom klase Izvedena te provjeriti ispis
            ISučelje s2 = new Izvedena();// null;
            PozoviNevirtualnuMetodu(s2);
            PozoviVirtualnuMetodu(s2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        // TODO:035 Pokrenuti i provjeriti testove (4 testa u grupi "VirtualniČlanovi" moraju proći).
    }
}
