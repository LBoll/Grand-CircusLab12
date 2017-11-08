using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class Validator
    {

        public static bool Continue(string answer)
        {
            Console.Write(answer);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nThank you for playing! ");
                return false;
            }
            else
            {
                Console.Write("Sorry, invalid input!\n");
                return Continue(answer);
            }
        }

        public static char GetPrompt()
        {
            bool success = false;

            while (!success)
            {
                Console.Write("Rock, Paper, or Scissors? (R/P/S) : ");
                string input = Console.ReadLine().ToLower(); ;
                if (input == "r" || input == "rock" || input == "p" || input == "paper" || input == "s" || input == "scissors")
                {
                    if (input == "r" || input == "rock")
                    {
                        success = true;
                        return 'r';
                    }
                    else if (input == "p" || input == "paper")
                    {
                        success = true;
                        return 'p';
                    }
                    else if (input == "s" || input == "scissors")
                    {
                        success = true;
                        return 's';
                    }
                }
                Console.WriteLine("This isn't Rock, Paper, Scissors, Spock, Lizard. Just stick to the standard three! ");
            }
            return 'z';
        }
    }
}