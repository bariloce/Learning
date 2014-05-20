namespace DesignPatterns.FactoryExample
{
    public class MercedesSportsCar : Car
    {
        public override string CompareSpeed(Car familyCar)
        {
            return this.GetType().Name + " is faster than " + familyCar.GetType().Name;
        }
    }
}