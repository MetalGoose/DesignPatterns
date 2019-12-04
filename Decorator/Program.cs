using System;
using Decorator.Beverages;
using Decorator.Beverages.Coffee;
using Decorator.Beverages.Condiments;

namespace Decorator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //Test order

            //First of all we order espresso without condiments
            IBeverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.Description + $" {beverage1.Cost()} $");

            //Second order - Dark Roast + Mocha x2 + Whip
            IBeverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + $" {beverage2.Cost()} $");

            //Third order - House Blend + Soy + Mocha + Whip
            IBeverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + $" {beverage3.Cost()} $");

            //*A more elegant way to create decorated objects will be presented in the description of the factory pattern.
            Console.ReadKey();
        }
    }
}