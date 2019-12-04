namespace Decorator.Beverages
{
    /// <summary>
    /// Base interface for all drinks in the cafe
    /// </summary>
    internal interface IBeverage
    {
        string Description { get; }

        double Cost();
    }
}