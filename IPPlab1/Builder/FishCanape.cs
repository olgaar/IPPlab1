using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public class FishCanape : Canape
    {
        public override string BuildName()
        {
            return "Fish canape";
        }
        public override float BuildPrice()
        {
            return 10;
        }
    }
}
