namespace DesignPatterns.FactoryExample
{
    public class AudiFactory : CarFactory
    {
        public override Car CreateSportsCar()
        {
            return new AudiSportsCar();
        }

        public override Car CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }
    }
}
