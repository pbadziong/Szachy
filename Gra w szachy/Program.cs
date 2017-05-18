using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra w szachy");

            Szachownica plansza = Szachownica.Instance;

            Pozycja p = new Pozycja();

            //zwracanie liczby figur na planszy
            Console.WriteLine("Figury, ktore znajduja sie na planszy: ");
            return Szachownica.Wyswietl();

            int FiguryNaPlanszy = plansza.LiczFigury();
            Console.WriteLine("Liczba figur, ktore sa na planszy: " + FiguryNaPlanszy);

            //ruch pionków
            Krol k = new Krol();
            string nazwa = k.GetType().Name;
            k.Color = Figura.Color;
            k.kolor = Figura.KOLOR_CZARNY;

            Console.WriteLine(k.ToString());

            Figura f = k;
            Console.WriteLine(f.ToString());

            Krol ka = new Krol();
            ka.kolor = Figura.KOLOR_BIALY;
            ka.kolor = Figura.KOLOR_CZARNY;

            Console.WriteLine(ka.ToString());
            ka.Pozycja = ka.kolor.ToString() + ka.nazwa.ToString();

            Krol p = new Krol();
            p.kolor = Figura.KOLOR_BIALY;
            p.kolor = Figura.KOLOR_CZARNY;

            p.Pole = p.kolor.ToString() + p.nazwa.ToString();

        }
    }
}
