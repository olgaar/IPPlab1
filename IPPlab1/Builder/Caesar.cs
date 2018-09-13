using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public abstract class Caesar : Salad
    {
        public abstract Sause BuildSause();
        public float BuildPrice()
        {
            return 30;
        }
        public abstract string BuildName();
    }
}
