using FactoryMethod.TypesOfPizza;

namespace FactoryMethod.RegionalPizzerias
{
    internal abstract class PizzaStore
    {
        /// <summary>
        /// The process of cooking pizza will not be different in different stores.
        /// Regional subclasses will make their own decisions regarding the creation of the object.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IPizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private protected abstract IPizza CreatePizza(string type);
    }
}