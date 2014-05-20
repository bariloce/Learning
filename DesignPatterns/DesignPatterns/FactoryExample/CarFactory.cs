namespace DesignPatterns.FactoryExample
{
    public abstract class CarFactory
    {
        public abstract Car CreateSportsCar();
        public abstract Car CreateFamilyCar();
    }
}
