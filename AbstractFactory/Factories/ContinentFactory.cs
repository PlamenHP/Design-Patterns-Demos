namespace AbstractFactory.Factories
{
    using AbstractFactory.Products;

    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
