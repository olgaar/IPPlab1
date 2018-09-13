using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public class MeatCanape : Canape
    {
        public override string BuildName()
        {
            return "Meat canape";
        }
        public override float BuildPrice()
        {
            return 15;
        }
    }
}
