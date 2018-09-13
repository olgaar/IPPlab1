using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Abstract_factory
{
    public class Kebab : AbstractSecondMeal
    {
        public override string GetIngredients()
        {
            return "Kebab: Chicken, potatoes, cabbage";
        }
    }
}
