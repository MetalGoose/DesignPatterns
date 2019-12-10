using System;

namespace FactoryMethod.TypesOfPizza.NY
{
    internal class NYPepperoniPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare NY Style PepperoniPizza Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake NY Style PepperoniPizza Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut NY Style PepperoniPizza Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box NY Style PepperoniPizza Pizza");
        }
    }
}