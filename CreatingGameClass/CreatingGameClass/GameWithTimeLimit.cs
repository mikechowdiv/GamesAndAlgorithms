using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGameClass
{
    class GameWithTimeLimit : Game
    {
        public int TimeLimit { get; set; }

        public GameWithTimeLimit(string name, int numPlayers, int timeLimit)
            : base(name, numPlayers)
        {
            TimeLimit = timeLimit;
        }

        public override string ToString()
        {
            return String.Format("{0}\nTime Limit: {1}", base.ToString(), TimeLimit); 
        }
    }
}
