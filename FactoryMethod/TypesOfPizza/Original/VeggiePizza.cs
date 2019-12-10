using System;

namespace FactoryMethod.TypesOfPizza.Original
{
    internal class VeggiePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Veggie Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Veggie Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Veggie Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box Veggie Pizza");
        }
    }
}