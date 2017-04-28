using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    class Krolowa
    {
        internal object nazwa;

        public virtual bool CzyMozliwyRuch { get; }
        public object kolor { get; internal set; }
        public object Pozycja { get; internal set; }
    }
}

