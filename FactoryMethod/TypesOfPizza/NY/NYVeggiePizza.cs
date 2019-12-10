using System;

namespace FactoryMethod.TypesOfPizza.NY
{
    internal class NYVeggiePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Style Veggie Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake NY Style Veggie Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut NY Style Veggie Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box NY Style Veggie Pizza");
        }
    }
}