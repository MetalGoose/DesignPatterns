using FactoryMethod.TypesOfPizza;
using FactoryMethod.TypesOfPizza.NY;

namespace FactoryMethod.RegionalPizzerias
{
    internal class NYPizzaStore : PizzaStore
    {
        private protected override IPizza CreatePizza(string type)
        {
            IPizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NYPepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYVeggiePizza();
            }

            return pizza;
        }
    }
}