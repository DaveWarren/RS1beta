using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS1beta
{
    class Program
    {
        private static Player player;
        private static Day currentDay;

        private static int weekCount = 1;
        private static int dayCount = 1;
        private static int yearCount = 1;


        static int Main(string[] args)
        {
            player = new Player();
            currentDay = Day.Monday;

            while (player.NotDead())
            {
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    return 0;
                }

                Advance();
            }

            return 1;
        }

        static void Advance()
        {
            // Determine what's happening

            // affect action

            // random event

            // world events

            // advance day by 1.
            var day = AdvanceNextDay();
            // output new day
            Console.WriteLine("Today is now {0} in your {1} week of your {2} year.", day, FormatNumber(weekCount), FormatNumber(yearCount));

        }

        private static Day AdvanceNextDay()
        {
            dayCount += 1;
            if (dayCount > 365) yearCount += 1;

            switch (currentDay)
            {
                case Day.Monday:
                    currentDay = Day.Tuesday;
                    return Day.Tuesday;

                case Day.Tuesday:
                    currentDay = Day.Wednesday;
                    return Day.Wednesday;

                case Day.Wednesday:
                    currentDay = Day.Thursday;
                    return Day.Thursday;

                case Day.Thursday:
                    currentDay = Day.Friday;
                    return Day.Friday;

                case Day.Friday:
                    currentDay = Day.Saturday;
                    return Day.Saturday;

                case Day.Saturday:
                    currentDay = Day.Sunday;
                    return Day.Sunday;

                case Day.Sunday:
                    currentDay = Day.Monday;
                    weekCount += 1;
                    return Day.Monday;

                default:
                    return Day.Sunday;

            }
        }

        private static string FormatNumber(int number)
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
