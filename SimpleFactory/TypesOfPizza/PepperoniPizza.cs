using System;

namespace SimpleFactory.TypesOfPizza
{
    internal class PepperoniPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare PepperoniPizza Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake PepperoniPizza Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut PepperoniPizza Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box PepperoniPizza Pizza");
        }
    }
}