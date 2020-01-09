using System;
using System.Collections;
using System.Collections.Generic;

namespace Vsite.CSharp.Sučelja
{
    class ImplicitnaEksplicitnaPretvorba
    {
        static void Main(string[] args)
        {
            // TODO:040 Provjeriti koja sučelja implementira klasa System.Collections.Generic.Queue<T>:
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1
            Queue<string> red = new Queue<string>(new string[] { "Mirko", "Slavko", "Jure" });

            //  Napisati naredbu koja će pomoću metode Queue<T>.Enqueue() dodati još jedan element u 'red' 
            red.Enqueue("Pero");

            //  Proslijediti objekt 'red' metodi IspišiSveElemente():
            IspišiSveElemente(red);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        public static void IspišiSveElemente<T>(IEnumerable<T> elementi)
        {
            //  Napraviti eksplicitnu pretvorbu proslijeđenog argumenta u ICollection i ispisati broj elemenata.
            Console.WriteLine(((ICollection)elementi).Count);

            foreach (var e in elementi)
            {
                Console.WriteLine(e);
            }
        }

        // TODO:044 Pokrenuti i provjeriti testove (test u grupi "ImplicitnaEksplicitnaPretvorba" mora proći).
    }
}
