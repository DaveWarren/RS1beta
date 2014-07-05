using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rockstar.Core
{
    public static class IntExtensions
    {
        public static string ToOrdinal(this int number)
        {
            var suffix = "";
            var ones = number % 10;
            var tens = Math.Floor(Convert.ToDecimal(number / 10)) % 10;
            if (tens == 1)
            {
                suffix = "th";
            }
            else
            {
                switch (ones)
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                }
            }
            return string.Format("{0}{1}", number, suffix);
        }

    }
}
