using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Prototype
{
    class ConcretePromo :PromoPrototype
    {
        public ConcretePromo(string menu, float price)
      : base(menu, price)
        {
        }

        // Returns a copy

        public override PromoPrototype Clone()
        {
            return (PromoPrototype)this.MemberwiseClone();
        }
    }
}
