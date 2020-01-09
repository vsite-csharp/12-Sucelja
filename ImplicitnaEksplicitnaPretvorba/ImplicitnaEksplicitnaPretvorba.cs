using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Sučelja
{
    class ImplicitnaEksplicitnaPretvorba
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1
            Queue<string> red = new Queue<string>(new string[] { "Mirko", "Slavko", "Jure" });

            red.Enqueue("Pero");
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
