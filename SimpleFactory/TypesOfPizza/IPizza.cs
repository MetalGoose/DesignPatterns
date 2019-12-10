namespace SimpleFactory.TypesOfPizza
{
    internal interface IPizza
    {
        void Prepare();

        void Bake();

        void Cut();

        void Box();
    }
}