using System;
using FactoryMethod.RegionalPizzerias;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NYPizzaStore store = new NYPizzaStore();
            store.OrderPizza("cheese");
            Console.ReadKey();
        }
    }
}