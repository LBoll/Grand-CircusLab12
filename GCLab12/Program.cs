using System;
using System.Collections;
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
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write($"Hello, {userName}! Would you like to play against TheGladiator or TheRogue? (g/r): ");
            string opponent = Console.ReadLine().ToLower().Trim();
            bool statement = true;

            while (statement)
            {
                if (opponent == "g")
                {
                    Console.WriteLine("You have selected TheGladiators! ");
                    break;
                }
                else if (opponent == "r")
                {
                    Console.WriteLine("You have selected TheRogues! ");
                    break;
                }
                else
                {
                    Console.WriteLine("Please pick from one of the opponents listed above! ");
                    statement = false;
                }
            }


            Console.Write("Rock, paper, or scissors? (R/P/S): ");
            string choice = Console.ReadLine();

            Console.WriteLine($"{userName}:{choice}");
            Console.WriteLine($"{opponent}:{choice}");


        }
    }
}
