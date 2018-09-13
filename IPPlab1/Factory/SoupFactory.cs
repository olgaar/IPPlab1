using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab1.Factory
{
    public class SoupFactory
    {
        public Ingredients GetIngredients(String type)
        {
            if (type == null)
            {
                return null;
            }
            if (type.Equals("ZEAMA"))
            {
                return new Zeama();

            }
            else if (type.Equals("CIORBA"))
            {
                return new Ciorba();

            }
            else if (type.Equals("SALTWORT"))
            {
                return new Saltwort();
            }

            return null;
        }
    }
}
