namespace Decorator.Beverages.Condiments
{
    /// <summary>
    /// Decorator for dynamically adding condiment to beverages
    /// </summary>
    internal interface ICondimentDecorator : IBeverage
    {
        new string Description { get; }
    }
}