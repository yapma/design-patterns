namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonBuilder builder = new PersonBuilder();
            builder.SetLastName("Erfanian");
            builder.SetFirstName("Yashar");
            builder.SetAge(30);

            var person = builder.Build();

            Console.WriteLine($"{person.FirstName} - {person.LastName}");
        }
    }
}