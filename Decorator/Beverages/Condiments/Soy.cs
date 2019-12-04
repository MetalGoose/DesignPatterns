namespace Decorator.Beverages.Condiments
{
    internal class Soy : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + ", Soy";

        public double Cost()
        {
            return _beverage.Cost() + .15;
        }
    }
}