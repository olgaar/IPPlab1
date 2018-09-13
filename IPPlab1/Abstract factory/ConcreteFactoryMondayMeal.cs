using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Abstract_factory
{
    class ConcreteFactoryMondayMeal :AbstractFactoryBusinessLunch
    {
        public override AbstractFirstMeal CreateFirstMeal()
        {
            return new CreamSoup();
        }
        public override AbstractSecondMeal CreateSecondMeal()
        {
            return new Kebab();
        }
    }
}
