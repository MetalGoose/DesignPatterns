using SimpleFactory.TypesOfPizza;

namespace SimpleFactory
{
    internal class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        /// <summary>
        /// Requests the factory to create an object by passing the order type
        /// </summary>
        /// <param name="pizzaType"></param>
        /// <returns></returns>
        public IPizza OrderPizza(string pizzaType)
        {
            var pizza = _factory.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}