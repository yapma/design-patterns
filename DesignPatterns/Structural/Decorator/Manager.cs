namespace Decorator
{
    internal class Manager : IEmployee
    {
        public double CalculateSallary()
        {
            return 90_000;
        }

        public double CalculateTax()
        {
            return CalculateSallary() / 100 * 10;
        }
    }
}
