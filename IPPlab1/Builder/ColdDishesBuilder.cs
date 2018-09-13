using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
   public class ColdDishesBuilder
    {
        public ColdDishes PrepareVegMenu()
        {
            ColdDishes coldDishes = new ColdDishes();
            coldDishes.addSalad(new VegCaesar());
            coldDishes.addCanape( new FishCanape());
            return coldDishes;
        }
        public ColdDishes PrepareMeatMenu()
        {
            ColdDishes coldDishes = new ColdDishes();
            coldDishes.addSalad(new StandardCaesar());
            coldDishes.addCanape(new MeatCanape());
            return coldDishes;
        }
      
    }
}
