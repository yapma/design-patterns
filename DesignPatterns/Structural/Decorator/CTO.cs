namespace Decorator
{
    internal class CTO : ManagerDecorator
    {
        public CTO(IEmployee employee) : base(employee)
        {
            taxDiscount = 500;
        }
    }
}
