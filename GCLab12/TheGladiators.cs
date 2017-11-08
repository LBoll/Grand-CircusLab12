using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    class TheGladiators : Player
    {
        public TheGladiators(string name)
            : base(name) 
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            this.Choice = Roshambo.Rock;
            return Choice;
        }
    }
}