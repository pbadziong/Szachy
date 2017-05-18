using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    class Szachownica
    {

        private static readonly Szachownica szachownica = new Szachownica();

        private const int wielkosc = Szachownica.WIELKOSC;
        private string wrzuc1 = "[x]", wrzuc2 = "[ ]";
        private string[,] plansza;


        public static Szachownica Instance
        {
            get
            {
                return szachownica;
            }
        }

        public List<char> Litery { get; private set; }

        static Szachownica()
        {
        }

        private Szachownica()
        {
            plansza = new string[wielkosc, wielkosc];
            plansza.Wyrzuc(wrzuc1, wrzuc2, wielkosc);
        }


        public string this[Figura f, Pozycja poz]
        {
            get
            {
                return plansza[poz.x, poz.b];
            }
            set
            {
                f.pozycja = poz;
                plansza[poz.a, poz.b] = value;
            }
        }

    static class LiczFigury
    {
        public static int LiczFigury(this Szachownica plansza)
        {
            int = 0;

            foreach (var b in plansza)
            {
                a++;
            }

            return a;
        }
    }

        public void Wyswietl()
        {
            string t;
            Litery = new Litery()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'
            };

            for (int y = 0; y < wielkosc; y++)
            {
                t += (wielkosc - y) + "\t";

                for (int z = 0; z < wielkosc; z++)
                {
                    t += plansza[y, z] + "\t";
                }

                t += '\n';
            }

            t += "\t";
            for (int w = 0; w < litery.Count; w++)
            {
                t += $" {litery.ElementAt(w).ToString().ToUpper()}\t";
            }

            Console.WriteLine(t);
        }
    }