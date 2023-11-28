namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine($"Manager Tax is {manager.CalculateTax()}");

            CTO cto = new CTO(manager);
            Console.WriteLine($"CTO Tax is {cto.CalculateTax()}");

            CEO ceo = new CEO(manager);
            Console.WriteLine($"CEO Tax is {ceo.CalculateTax()}");
        }
    }
}