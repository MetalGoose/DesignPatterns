namespace Decorator.Beverages.Coffee
{
    internal class Decaf : IBeverage
    {
        public string Description { get; }

        public Decaf()
        {
            Description = "Decaf";
        }

        public double Cost() => 1.05;
    }
}