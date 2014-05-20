namespace DesignPatterns.FactoryExample
{
    public class Driver
    {
        readonly Car sportsCar;
        readonly Car familyCar;

        public Driver(CarFactory carFactory)
        {
            sportsCar = carFactory.CreateSportsCar();
            familyCar = carFactory.CreateFamilyCar();
        }

        public string CompareSpeeds()
        {
            return familyCar.CompareSpeed(sportsCar);
        }
    }
}
