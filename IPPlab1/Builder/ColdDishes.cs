using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Builder
{
    public class ColdDishes
    {
        private List<Salad> salads = new List<Salad>();
        private List<Canape> canapes = new List<Canape>();

        public void addSalad(Salad salad)
        {
            salads.Add(salad);
        }
        public void addCanape( Canape canape)
        {
            canapes.Add(canape);
        }

        public float getCost()
        {
            float cost = 0.0f;

            foreach (Salad salad in salads)
            {
                cost += salad.BuildPrice();
            }
            foreach (Canape canape in canapes)
            {
                cost += canape.BuildPrice();
            }
            return cost;
        }

        public void showItems()
        {

            foreach (Salad salad in salads)
            {
                Console.Write("Salad : " + salad.BuildName());
                Console.Write(", Sause : " + salad.BuildSause().BuildName());
                Console.WriteLine(", Price : " + salad.BuildPrice());
            }
            foreach (Canape canape in canapes)
            {
                Console.Write("Canape : " + canape.BuildName());
                Console.WriteLine(", Price : " + canape.BuildPrice());
            }
        }
    }
}
