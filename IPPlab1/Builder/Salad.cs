using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public interface Salad
    {
        string BuildName();
        Sause BuildSause();
       float BuildPrice();
    }
}
