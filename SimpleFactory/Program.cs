using System;

namespace SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);

            pizzaStore.OrderPizza("cheese");
            Console.ReadKey();
        }
    }
}