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

            Pozycja p = new Pozycja("C7");

            Krol k = new Krol();
            string nazwa = k.GetType().Name;
            k.kolor = Figura.KOLOR_BIALY;
            k.kolor = Figura.KOLOR_CZARNY;

            Console.WriteLine(k.ToString());

            Figura f = k;
            Console.WriteLine(f.ToString());

            Krolowa ka = new Krolowa();
            ka.kolor = Figura.KOLOR_BIALY;
            ka.kolor = Figura.KOLOR_CZARNY;

            Console.WriteLine(ka.ToString());
            ka.Pozycja = ka.kolor.ToString() + ka.nazwa.ToString();

            Pionek p = new Pionek();
            p.kolor = Figura.KOLOR_BIALY;
            p.kolor = Figura.KOLOR_CZARNY;

            p.Pole = p.kolor.ToString() + p.nazwa.ToString();

            Console.WriteLine(p.C7);
        }
    }
}
