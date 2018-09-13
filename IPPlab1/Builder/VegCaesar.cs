using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public class VegCaesar: Caesar
    {
        public override Sause BuildSause()
        {
            return new Dutch();
        }
        public override string BuildName()
        {
            return "VegCaesar salad";
        }
    }
}
