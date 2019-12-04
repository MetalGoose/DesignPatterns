namespace Decorator.Beverages.Coffee
{
    internal class DarkRoast : IBeverage
    {
        public string Description { get; }

        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public double Cost() => .99;
    }
}