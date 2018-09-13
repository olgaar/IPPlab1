using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Abstract_factory
{
    class ConcreteFactoryTuesdayMeal: AbstractFactoryBusinessLunch
    {
        public override AbstractFirstMeal CreateFirstMeal()
        {
            return new Bors();
        }
        public override AbstractSecondMeal CreateSecondMeal()
        {
            return new Pizza();
        }
    }
}
