namespace Decorator.Beverages.Condiments
{
    internal class Mocha : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public string Description => _beverage.Description + ", Mocha";

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }
}