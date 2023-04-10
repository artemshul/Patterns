using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza();
    }

    public class CheesePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new CheesePizza();
        }
    }

    public class PepperoniPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }

    public class BarbecuePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new BarbecuePizza();
        }
    }
}
