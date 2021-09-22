using System;
namespace Decorator
{
    public class Whip: CondimentDecorator
    {
        private readonly Beverage beverage;
        public Whip(Beverage bev)
        {
            this.beverage = bev;
        }

        public override string Description => beverage.Description + " with Whip";

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }
}
