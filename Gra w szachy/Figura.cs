using System;
using System.Collections.Generic;
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

        public static string KOLOR_BIALY = "Bialy";
        public static string KOLOR_CZARNY = "Czarny";
        public string kolor;

        protected Pozycja

        Pozycja
        {
            get
            {
                return pozycja;
            }

            set
            {
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

        public static implicit operator Figura(Krol v)
        {
            throw new NotImplementedException();
        }
    }
}
