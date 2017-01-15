namespace AbstractFactory
{
    using AbstractFactory.Factories;
    using Products;

    class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnovore;

        public AnimalWorld(ContinentFactory factory)
        {
            this.herbivore = factory.CreateHerbivore();
            this.carnovore = factory.CreateCarnivore();
        }

        public void RunFoodchain()
        {
            carnovore.Eat(herbivore);
        }
    }
}
