using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGameClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //creata a class named Game. Include auto-implemented properties for the game's name and maximum number of players.
            //Also include ToString() Game method that overrides the Object class's ToString() method and returns a string that
            //contains the name of the class using getType(), the name of the Game, and the number of players.

            var game = new Game("Minecraft", 16);
            var gameWithTimeLimt = new GameWithTimeLimit("Team6", 32, 1000);

            Console.WriteLine(game);
            Console.WriteLine(gameWithTimeLimt);

            Console.ReadLine();
        }
    }
}
