using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class TheRogues : Player
    {
        Random random;
        public TheRogues(string name)
            :base(name)
        {
            random = new Random();
        }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo choice = (Roshambo)random.Next(2);
            Choice = choice;
            return choice;
        }
    }
}