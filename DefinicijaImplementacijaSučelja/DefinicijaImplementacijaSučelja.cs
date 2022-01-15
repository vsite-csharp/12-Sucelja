using System;

namespace Vsite.CSharp.Sučelja
{
    // definicija sučelja:
    interface IMojeSučelje
    {
        // deklaracija (samo potpis) metode:
        void GenerirajMojDogađaj();
        // deklaracija svojstva:
        string Svojstvo { set; get; }
        // deklaracija dogadjaja:
        event MojDelegat MojDogađaj;
    }

    // deklaracija delegata
    public delegate void MojDelegat(object sender, EventArgs e);


    // 020 Napišite kod klase Implementacija tako da implementira sučelje IMojeSučelje. 
    // 021 Implementirajte metodu GenerirajMojDogađaj tako da ona generira događaj MojDogađaj
    // 022 Implementirajte kod za Svojstvo
    class Implementacija : IMojeSučelje
    {
        public string Svojstvo { get => svojstvo ; set => svojstvo = value; }

        public event MojDelegat MojDogađaj;

        public void GenerirajMojDogađaj()
        {
            MojDogađaj(this, EventArgs.Empty);
        }

        private string svojstvo;
    }

    class DefinicijaImplementacijaSučelja
    {
        // metode kao argument ne primaju konkretne tipove nego sučelja! 
        static void IspišiSvojstvo(IMojeSučelje ms)
        {
            ms.Svojstvo = "Dobar dan";
            Console.WriteLine(ms.Svojstvo);
        }

        static void DigniDogađaj(IMojeSučelje ms)
        {
            ms.MojDogađaj += ObradiDogađaj;
            ms.GenerirajMojDogađaj();
        }

        static void ObradiDogađaj(object sender, EventArgs args)
        {
            Console.WriteLine("Događaj obrađen!");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 023 Inicijalizirajte objekt ms instancom objekta Implementacija i provjerite što će se ispisati izvođenjem koda
            IMojeSučelje ms = new Implementacija();

            IspišiSvojstvo(ms);
            DigniDogađaj(ms);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        // TODO:024 Pokrenuti i provjeriti testove (2 testa u grupi "DefinicijaImplementacijaSučelja" moraju proći)
    }
}
