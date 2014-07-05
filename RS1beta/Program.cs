using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rockstar.Core;
using RockstarGame;

namespace RS1beta
{
    class Program
    {
        private static Player _player;
        private static Day _currentDay;

        private static int _weekCount = 1;
        private static int _dayCount = 1;
        private static int _yearCount = 1;


        static int Main(string[] args)
        {
            _player = new Player();
            _currentDay = Day.Monday;

            Console.WriteLine("Simulator");
            WritePlayerStatus();

            while (_player.NotDead())
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        return 0;

                    case "p":
                        WritePlayerStatus();
                        break;
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
            Console.WriteLine("Today is now {0} in your {1} week of your {2} year.", day, _weekCount.ToOrdinal(), _yearCount.ToOrdinal());

        }

        private static void WritePlayerStatus()
        {
            Console.WriteLine("Health : {0}", _player.Health);
            Console.WriteLine("Creativity : {0}", _player.Creativity);
            Console.WriteLine("Happiness : {0}", _player.Happiness);
            Console.WriteLine("Alertness : {0}", _player.Alertness);
        }

        private static Day AdvanceNextDay()
        {
            _dayCount += 1;
            if (_dayCount > 365) _yearCount += 1;

            switch (_currentDay)
            {
                case Day.Monday:
                    _currentDay = Day.Tuesday;
                    return Day.Tuesday;

                case Day.Tuesday:
                    _currentDay = Day.Wednesday;
                    return Day.Wednesday;

                case Day.Wednesday:
                    _currentDay = Day.Thursday;
                    return Day.Thursday;

                case Day.Thursday:
                    _currentDay = Day.Friday;
                    return Day.Friday;

                case Day.Friday:
                    _currentDay = Day.Saturday;
                    return Day.Saturday;

                case Day.Saturday:
                    _currentDay = Day.Sunday;
                    return Day.Sunday;

                case Day.Sunday:
                    _currentDay = Day.Monday;
                    _weekCount += 1;
                    return Day.Monday;

                default:
                    return Day.Sunday;

            }
        }

        
    }
}
