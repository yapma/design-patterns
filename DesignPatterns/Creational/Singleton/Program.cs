namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VoteMachine vm1 = VoteMachine.Instance;
            VoteMachine vm2 = VoteMachine.Instance;
            VoteMachine vm3 = VoteMachine.Instance;

            vm1.RegisterVote();
            vm2.RegisterVote();
            vm3.RegisterVote();

            Console.WriteLine(vm1.TotalVotes);
        }
    }
}