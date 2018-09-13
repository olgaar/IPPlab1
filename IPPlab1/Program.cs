using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPPlab1.Builder;
using IPPlab1.Factory;
using IPPlab1.Singleton;
using IPPlab1.Abstract_factory;
using IPPlab1.Prototype;

namespace IPPlab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Builder DEMO:-------");
            var coldDishesBuilder = new ColdDishesBuilder();
            Console.WriteLine("Let's build meat menu");
            var coldDishes = coldDishesBuilder.PrepareMeatMenu();
            coldDishes.showItems();
            Console.WriteLine ("Total Cost: " + coldDishes.getCost());

            Console.WriteLine("Let's build veg menu");
            coldDishes = coldDishesBuilder.PrepareVegMenu();
            coldDishes.showItems();
            Console.WriteLine("Total Cost: " + coldDishes.getCost());
            Console.WriteLine();


            Console.WriteLine("-------Factory DEMO:-------");
            var soupFactory = new SoupFactory();
            Ingredients ing1 = soupFactory.GetIngredients("ZEAMA");
            ing1.ShowIngredients();

            Ingredients ing2 = soupFactory.GetIngredients("CIORBA");
            ing2.ShowIngredients();

            Ingredients ing3 = soupFactory.GetIngredients("SALTWORT");
            ing3.ShowIngredients();

            Console.WriteLine();


            Console.WriteLine("-------Singleton DEMO:-------");
            SingleObject obj = SingleObject.GetInstance();
            obj.ShowAddress();

            Console.WriteLine();


            Console.WriteLine("-------Abstract factory DEMO:-------");
            var mondayFactory = new ConcreteFactoryMondayMeal();
            var tuesdayFactory = new ConcreteFactoryTuesdayMeal();
            var client = new AbstractFactoryClient(mondayFactory);
            Console.WriteLine("MONDAY Business lunch first meal: " + client.getFirstMeal());
            Console.WriteLine("MONDAY Business lunch second meal: " + client.getSecondMeal());

            client = new AbstractFactoryClient(tuesdayFactory);
            Console.WriteLine("TUESDAY Business lunch first meal: " + client.getFirstMeal());
            Console.WriteLine("TUESDAY Business lunch second meal: " + client.getSecondMeal());

            Console.WriteLine();


            Console.WriteLine("-------Prototype DEMO:-------");
            ConcretePromo originalObject = new ConcretePromo("Burger, cola", 50);
            Console.WriteLine("Original promo menu: " + originalObject.Menu + " and price: " + originalObject.Price);
            ConcretePromo clonedObject = (ConcretePromo)originalObject.Clone();
            Console.WriteLine("Cloned promo menu: " + clonedObject.Menu + " and price: " + clonedObject.Price);
            

        }
    }
}
