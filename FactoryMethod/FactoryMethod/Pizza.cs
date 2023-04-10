using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public abstract string GetDescription();
    }

    public class CheesePizza : Pizza
    {
        string receipt = "ketchup, cheese";
        public override string GetDescription()
        {
            return "Cheese Pizza\n" + receipt;
        }
    }

    public class PepperoniPizza : Pizza
    {
        string receipt = "ketchup, cheese, peppers, tomatoes, sausages";
        public override string GetDescription()
        {
            return "Pepperoni Pizza\n" + receipt;
        }
    }

    public class BarbecuePizza : Pizza
    {
        string receipt = "ketchup, cheese, beef, tomatoes, mushrooms, onions";
        public override string GetDescription()
        {
            return "Barbecue Pizza\n" + receipt;
        }
    }
}
