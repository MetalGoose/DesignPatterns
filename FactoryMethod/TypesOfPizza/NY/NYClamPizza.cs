using System;

namespace FactoryMethod.TypesOfPizza.NY
{
    internal class NYClamPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Style Clam Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake NY Style Clam Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut NY Style Clam Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box NY Style Clam Pizza");
        }
    }
}