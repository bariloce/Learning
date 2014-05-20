namespace DesignPatterns.FactoryExample
{
    public class MercedesFactory : CarFactory
    {
        public override Car CreateSportsCar()
        {
            return new MercedesSportsCar();
        }

        public override Car CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }
    }
}