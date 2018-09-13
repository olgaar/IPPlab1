using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Prototype
{
    public abstract class PromoPrototype
    {
        private string menu;
        private float price;

        // Constructor

        public PromoPrototype(string menu, float price)
        {
            this.menu = menu;
            this.price = price;
        }

        // Gets id

        public string Menu
        {
            get { return menu; }
        }
        public float Price
        {
            get { return price; }
        }

        public abstract PromoPrototype Clone();
    }
}
