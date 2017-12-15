using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGameClass
{
    class Game
    {
        public string GameName { get; set; }
        public int MaxNumPlayers { get; set; }
        public Game(string gameName, int maxNumPlayers)
        {
            GameName = gameName;
            MaxNumPlayers = maxNumPlayers;
        }
        public override string ToString()
        {
            return String.Format("CLass info: {0}\nGame's Name: {1}\nMaximun Number of Players: {2}",
                GetType(), GameName, MaxNumPlayers);
        }
    }
}
