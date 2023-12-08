using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VoteMachine
    {
        private static VoteMachine _instance = null;
        private int _totalVotes = 0;

        private VoteMachine()
        {
        }

        public static VoteMachine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VoteMachine();

                return _instance;
            }
        }


        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }

        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
}
