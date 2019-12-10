using System;

namespace FactoryMethod.TypesOfPizza.Original
{
    internal class ClamPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Clam Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Clam Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Clam Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box Clam Pizza");
        }
    }
}