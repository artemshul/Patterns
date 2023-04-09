using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BurgerDecorator : Burger
    {
        public Burger burger;

        public BurgerDecorator(Burger burger)
        {
            this.burger = burger;
            price = burger.price;
        }

        public override string GetDescription()
        {
            return burger.GetDescription();
        }
    }

    public class BaconDecorator : BurgerDecorator
    {
        public BaconDecorator(Burger burger) : base(burger) 
        {
            price += 1.50;
        }

        public override string GetDescription()
        {
            return $"{burger.GetDescription()} with bacon";
        }
    }

    public class OnionDecorator : BurgerDecorator
    {
        public OnionDecorator(Burger burger) : base(burger) 
        {
            price += 0.50;
        }

        public override string GetDescription()
        {
            return $"{burger.GetDescription()} with onion";
        }
    }

    public class TomatoDecorator : BurgerDecorator
    {
        public TomatoDecorator(Burger burger) : base(burger) 
        {
            price += 0.75;
        }

        public override string GetDescription()
        {
            return $"{burger.GetDescription()} with tomato";
        }
    }

    public class LettuceDecorator : BurgerDecorator
    {
        public LettuceDecorator(Burger burger) : base(burger) 
        {
            price += 0.25;
        }

        public override string GetDescription()
        {
            return $"{burger.GetDescription()} with lettuce";
        }
    }
}
