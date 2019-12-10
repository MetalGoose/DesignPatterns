using SimpleFactory.TypesOfPizza;

namespace SimpleFactory
{
    /// <summary>
    /// class Simple Pizza Factory is engaged exclusively in the creation of pizza for their customers
    /// </summary>
    internal class SimplePizzaFactory
    {
        public IPizza CreatePizza(string pizzaType)
        {
            IPizza pizza = null;

            if (pizzaType.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}