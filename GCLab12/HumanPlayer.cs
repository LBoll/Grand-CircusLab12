using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name)
            :base(name)
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            char choice = Validator.GetPrompt();

            if (choice == 'r')
            {
                Choice = Roshambo.Rock;
            }
            else if (choice == 'p')
            {
                Choice = Roshambo.Paper;
            }
            else if (choice == 's')
            {
                Choice = Roshambo.Scissors;
            }
            return Choice;
        }
    }
}