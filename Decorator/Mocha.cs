using System;
namespace Decorator
{
    public class Mocha: CondimentDecorator
    {
        private readonly Beverage beverage;
        public Mocha(Beverage bev)
        {
            beverage = bev;
        }

        public override string Description => beverage.Description + " with Mocha";

        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }
    }
}
