using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Sučelja
{
    class ImplicitnaEksplicitnaPretvorba
    {
        static void Main(string[] args)
        {
            Queue<string> red = new Queue<string>(new string[] { "Mirko", "Slavko", "Jure" });

            red.Enqueue("Antun");
            IspišiSveElemente(red);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        public static void IspišiSveElemente<T>(IEnumerable<T> elementi)
        {

            Console.WriteLine(((ICollection)elementi).Count);
            foreach (var e in elementi)
            {
                Console.WriteLine(e);
            }
        }

    }
}
