using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS1beta
{
    public class Player
    {
        public Player()
        {
            this.Health = 100;
            this.Creativity = 100;
            this.Happiness = 100;
            this.Alertness = 100;
        }

        public bool NotDead()
        {
            return true;
        }

        public double Health { get; set; }
        public double Creativity { get; set; }
        public double Happiness { get; set; }
        public double Alertness { get; set; }
    }
}
