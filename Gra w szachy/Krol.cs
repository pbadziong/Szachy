using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_szachy
{
    class Krol
    {
        public virtual bool CzyMozliwyRuch { get; }
        public object kolor { get; internal set; }
    }
}
