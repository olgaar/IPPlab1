using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Abstract_factory
{
    public class AbstractFactoryClient
    {
        private AbstractFirstMeal abstractFirstMeal;
        private AbstractSecondMeal abstractSecondMeal;

        public string getFirstMeal()
        {
           return this.abstractFirstMeal.GetIngredients();
        }
        public string getSecondMeal()
        {
            return this.abstractSecondMeal.GetIngredients();
        }

        public AbstractFactoryClient(AbstractFactoryBusinessLunch factory)
        {
            abstractFirstMeal = factory.CreateFirstMeal();
            abstractSecondMeal = factory.CreateSecondMeal();
        }
    }
}
