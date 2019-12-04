namespace Decorator.Beverages.Coffee
{
    internal class Espresso : IBeverage
    {
        public string Description { get; }

        public Espresso()
        {
            Description = "Espresso";
        }

        public double Cost() => 1.99;
    }
}