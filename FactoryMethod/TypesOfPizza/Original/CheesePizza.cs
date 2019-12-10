using System;

namespace FactoryMethod.TypesOfPizza.Original
{
    internal class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Cheese Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Cheese Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Cheese Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box Cheese Pizza");
        }
    }
}