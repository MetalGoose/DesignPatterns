namespace Decorator.Beverages.Coffee
{
    internal class HouseBlend : IBeverage
    {
        public string Description { get; }

        public HouseBlend()
        {
            Description = "House Blend";
        }

        public double Cost() => .89;
    }
}