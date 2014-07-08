using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockstar.Components
{
    public class PlayerAttribute
    {
        private readonly int _minValue;
        private readonly int _maxValue;

        public PlayerAttribute(int min, int max, int initial)
        {
            _minValue = min;
            _maxValue = max;
            CurrentValue = initial;
        }

        public int CurrentValue { get; internal set; }

        public void IncrementValue(int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                if (CurrentValue < _maxValue)
                {
                    CurrentValue++;
                }
            }
        }

        public void DecrementValue(int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                
                if (CurrentValue > _minValue)
                {
                    CurrentValue--;
                    // Attribute depleted Raise event                    
                }
            }
        }

        public override string ToString()
        {
            return this.CurrentValue.ToString();
        }
    }
}
