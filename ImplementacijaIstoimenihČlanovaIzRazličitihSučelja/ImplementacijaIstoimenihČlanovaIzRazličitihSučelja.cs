﻿using System;

namespace Vsite.CSharp.Sučelja
{
    class ImplementacijaIstoimenihČlanovaIzRazličitihSučelja
    {
        public interface ISkokUvis
        {
            void Skoči();
        }

        public interface ISkokUdalj
        {
            void Skoči();
        }

        // TODO:050 U implementaciju metode Skoči u klasi Desetobojac napisati naredbu koja će ispisati "Hop". U metodi Main pozvati tu metodu, pokrenuti program i provjeriti ispis.

        // TODO:051 Definirati da klasa Desetobojac implementira sučelje ISkokUvis. U implementaciji metode tog sučelja treba ispisati "Hop u vis".
        // TODO:052 U metodi Main dodati naredbu koja će pozvati metodu Skoči iz sučelja ISkokUVis. Pokrenuti program i provjeriti ispise.

        // TODO:053 Definirati da klasa Desetobojac implementira sučelje ISkokUDalj.U implementaciji metode tog sučelja treba ispisati "Hop u dalj".
        // TODO:054 U metodi Main dodati naredbu koja će pozvati metodu Skoči iz sučelja ISkokUDalj. Pokrenuti program i provjeriti ispise.
        public class Desetobojac
        {
            public void Skoči()
            {
            }
        }

        // TODO:055 Pokrenuti i provjeriti testove (3 testa u grupi "ImplementacijeIstoimenihČlanovaRazličitihSučelja" moraju proći).

        static void Main(string[] args)
        {
            Desetobojac db = new Desetobojac();


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
