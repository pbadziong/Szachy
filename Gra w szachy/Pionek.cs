using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    class Pionek
    {
        internal object nazwa;

        public virtual bool CzyMozliwyRuch { get; }
        public object kolor { get; internal set; }
        public object Pole { get; internal set; }
    }
}
