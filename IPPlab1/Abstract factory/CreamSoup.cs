using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Abstract_factory
{
    public class CreamSoup : AbstractFirstMeal
    {
        public override string GetIngredients()
        {
            return "CreamSoup: Chicken, mushrooms, cheese";
        }
    }
}
