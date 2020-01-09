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

        public class Izvedena : Bazna, ISučelje
        {
            public new string NevirtualnaMetoda()
            {
                return "Izvedena.NevirtualnaMetoda";
            }

            public override string VirtualnaMetoda()
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

            ISučelje s1 = new Bazna();
            PozoviNevirtualnuMetodu(s1);
            PozoviVirtualnuMetodu(s1);


            ISučelje s2 = new Izvedena();
            PozoviNevirtualnuMetodu(s2);
            PozoviVirtualnuMetodu(s2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
