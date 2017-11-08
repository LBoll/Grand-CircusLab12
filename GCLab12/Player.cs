using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab12
{
    abstract class Player
    {
        private string name;
        private Roshambo choice;

        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Roshambo Choice
        {
            get { return choice; }
            set { choice = value; }
        }

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return $"{Name}: {Choice}!";
        }
    }
}