namespace Decorator
{
    internal class CEO : ManagerDecorator
    {
        public CEO(IEmployee employee) : base(employee)
        {
            taxDiscount = 1500;
        }
    }
}
