using System;

namespace Decorator.Beverages.Condiments
{
    internal class Whip : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public string Description => _beverage.Description + ", Whip";

        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}