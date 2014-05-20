namespace DesignPatterns.FactoryExample
{
    public class AudiFamilyCar : Car
    {
        public override string CompareSpeed(Car sportsCar)
        {
            return this.GetType().Name + " is slower than " + sportsCar.GetType().Name;
        }
    }
}