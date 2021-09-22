using System;
namespace Decorator
{
    public class Soy: CondimentDecorator
    {
        private readonly Beverage beverage;
        public Soy(Beverage bev)
        {
            this.beverage = bev;
        }

        public override string Description => beverage.Description + " with Soy Milk";

        public override double Cost()
        {
            return 0.15 + beverage.Cost();
        }
    }
}
