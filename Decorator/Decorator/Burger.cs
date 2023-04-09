using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Burger
    {
        public double price = 0;
        public abstract string GetDescription();
        public double GetPrice()
        {
            return price;
        }
    }

    public class Cheeseburger : Burger
    {
        public Cheeseburger()
        {
            price += 4.99;
        }
        public override string GetDescription()
        {
            return "Cheeseburger";
        }
    }

    public class Hamburger : Burger
    {
        public Hamburger()
        {
            price += 3.99;
        }
        public override string GetDescription()
        {
            return "Hamburger";
        }
    }

    public class VeggieBurger : Burger
    {
        public VeggieBurger()
        {
            price += 4.49;
        }

        public override string GetDescription()
        {
            return "Veggie Burger";
        }
    }

    public class ChickenBurger : Burger
    {
        public ChickenBurger()
        {
            price += 5.49;
        }

        public override string GetDescription()
        {
            return "Chicken Burger";
        }
    }
}
