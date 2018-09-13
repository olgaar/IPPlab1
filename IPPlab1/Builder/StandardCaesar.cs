using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public class StandardCaesar : Caesar
    {
        public override Sause BuildSause()
        {
            return new Pesto();
        }
        public override string BuildName()
        {
            return "Standard Caesar salad";
        }
    }
}
