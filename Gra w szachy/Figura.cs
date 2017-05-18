using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    abstract class Figura
    {
        public string Nazwa
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public Pozycja pozycja = null;

        public string Color;
        public delegate void ZmianaPozycji();

        protected Pozycja

        Pozycja
        {
            get { return pozycja; }

            set
            {
                if (null != ZmianaPozycji) ZmianaPozycji();
                pozycja = value;
            }
        }

        public virtual bool CzyMozliwyRuch(Pozycja nowaPozycja)
        {
            return true;
        }
        Figura()
        {

        }
        Figura(Pozycja pozycja)
        {
            this.pozycja = pozycja;
        }

        public void ZmianaPozycji()
        {
            Console.WriteLine("{Nazwa} zmienil pozycje");
        }

        public string ToString()
        {
            return "Pionek: {Color} {Nazwa}";
        }

    }
}
