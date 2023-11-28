namespace Decorator
{
    internal class ManagerDecorator : IEmployee
    {
        private readonly IEmployee employee;
        protected double taxDiscount;

        public ManagerDecorator(IEmployee employee)
        {
            taxDiscount = 1_000;
            this.employee = employee;
        }

        public double CalculateSallary()
        {
            return employee.CalculateSallary();
        }

        public double CalculateTax()
        {
            return employee.CalculateTax() - taxDiscount;
        }
    }
}
