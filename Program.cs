using System;
using LegoMinifigures.Players;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            LukaDoncic player1 = new LukaDoncic("Forward|Guard", "Getting to the basket", 3, "6 feet 7 inches");
            JaMorant player2 = new JaMorant("Point Guard", "Speed and Athleticism", 2, "6 feet 3 inches");
            Console.WriteLine("");
            player1.Dribble();
            player2.Dribble();
            player1.Speak();
            player2.Speak();
            player1.Pass();
            player2.Pass();
            player1.Shoot();
            player2.Shoot();
            player1.Results();
            player2.Results();
        }
    }
}
