using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors! ");
            Console.Write("Enter your name: ");
            Player userName = new HumanPlayer(Console.ReadLine());

            Player r = new TheRogues("TheRogues");
            Player g = new TheGladiators("TheGladiators");

            bool repeat = true;
            while (repeat)
            {
                Console.Write($"{userName.Name}, would you like to play against TheRogues or TheGladiators? ");

                Player opponent = UserOpponent(r, g);

                userName.GenerateRoshambo();
                opponent.GenerateRoshambo();

                Console.WriteLine(userName);
                Console.WriteLine(opponent);
                repeat = Validator.Continue("Would you like to play again? (Y/N?): ");
                Console.WriteLine();
            }
        }

        private static Player UserOpponent(Player r, Player g)
        {
            bool validOpponent = false;
            Player opponent = null;

            while (!validOpponent)
            {
                string opponentChoice = Console.ReadLine().ToLower();
                if (opponentChoice == r.Name.ToLower())
                {
                    opponent = r;
                    validOpponent = true;
                }
                else if (opponentChoice == g.Name.ToLower())
                {
                    opponent = g;
                    validOpponent = true;
                }
                else
                {
                    Console.Write("Please pick from one of the choices listed above! ");
                }
            }
            return opponent;
        }
    }
}