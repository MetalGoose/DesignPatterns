using System;

namespace FactoryMethod.TypesOfPizza.NY
{
    internal class NYCheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Style Cheese Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake NY Style Cheese Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut NY Style Cheese Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box NY Style Cheese Pizza");
        }
    }
}