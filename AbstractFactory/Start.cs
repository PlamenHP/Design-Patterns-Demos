namespace AbstractFactory
{
    using AbstractFactory.Factories;

    class Start
    {
        static void Main()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodchain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodchain();

            System.Console.ReadKey();
        }
    }
}
