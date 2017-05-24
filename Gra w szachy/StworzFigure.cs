using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    class StworzFigure
    {
        public static Figura TworzenieFigury(Pozycja poz = null, Typ figura, Color Kolor)
        {
            Figura TworzenieFigury = null;

            switch (figura)
            { 
                case Typ.Krol:
                    {
                        TworzenieFigury = new Krol(Kolor.Nazwa(), poz);
                        break;
                    }
                case Typ.Krolowa:
                    {
                        TworzenieFigury = new Krolowa(Kolor.Nazwa(), poz);
                        break;
                    }
                case Typ.Pionek:
                    {
                        TworzenieFigury = new Pionek(Kolor.Nazwa(), poz);
                        break;
                    }
                case Typ.Goniec:
                    {
                        TworzenieFigury = new Goniec(Kolor.Nazwa(), poz);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Figura", "typ nieznany");
                    }
            }

            return TworzenieFigury;
        }
    }
}

