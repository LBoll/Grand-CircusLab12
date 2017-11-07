using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    abstract class Player
    {
        public string name { get; set; }
        public Roshambo roshambo { get; set; }

        abstract public Roshambo GenerateRoshambo();

        public Player(string name,Roshambo roshambo)
        {
            this.name = name;
            this.roshambo = roshambo;
        }

        public override string ToString()
        {
            return $"{name} {GenerateRoshambo()}";
        }
    }
}