using System;

namespace Vsite.CSharp.Sučelja
{
    class TipskiSigurneImplementacije
    {
        // TODO:060 Dopuniti strukturu Duljina tako da implementira sučelje IComparable i napisati kod za metodu CompareTo.
        public struct Duljina : IComparable, IComparable<Duljina>
        {
            private int duljina;

            public Duljina(int duljina)
            {
                this.duljina = duljina;
            }

             int IComparable.CompareTo(object obj)
            {
                Duljina a = (Duljina)obj;
                return duljina - a.duljina;
            }
            public int CompareTo(Duljina d2)
            {
                return duljina - d2.duljina;
            }
            public override string ToString()
            {
                return string.Format("{0} m", duljina);
            }
        }

        public static void Usporedi(Duljina d1, Duljina d2)
        {
            int usporedba = 0; d1.CompareTo(d2);
            if (usporedba == 0)
                Console.WriteLine("{0} = {1}", d1, d2);
            else if (usporedba > 0)
                Console.WriteLine("{0} > {1}", d1, d2);
            else
                Console.WriteLine("{0} < {1}", d1, d2);
        }

        static void Main(string[] args)
        {
            try
            {
                Duljina d1 = new Duljina(2);
                Duljina d2 = new Duljina(1);
                // TODO:062 Dodati naredbu koja će metodi Usporedi proslijediti duljine d1 i d2 te provjeriti ispis.
                Usporedi(d1, d2);

                // TODO:063 Dodati naredbu koja će metodi Usporedi proslijediti d1 i string "pero". Provjeriti javlja li prevoditelj pogrešku te ako nema pogreške, pokrenuti program i provjeriti ispis.
                //Usporedi(d1, "Pero");
                // TODO:064 Promijeniti implementaciju sučelja IComparable tako da prevoditelj javi pogrešku na usporedbu strukture Duljina i stringa. Provjeriti javlja li prevoditelj pogrešku.

                // TODO:065 Dopuniti strukturu Duljina tako da implementira i sučelje IComparable<Duljina>. Provjeriti javlja li prevoditelj pogrešku.

                // TODO:066 Pokrenuti i provjeriti testove (3 testa u grupi "TipskiSigurnaImplementacija" moraju proći).
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
