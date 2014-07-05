using System;
using System.Reflection;
using Ninject;
using Rockstar.Components;
using Rockstar.Core.Game;
using Rockstar.Core.Utilities;
using RockstarGame;

namespace RS1beta
{
    class Program
    {
        private static Player _player;
        private static Today _currentDay;

        private static ITimeManager _timeManager;

        internal static void Init()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _timeManager = kernel.Get<ITimeManager>();
        }

        static int Main(string[] args)
        {
            Init();

            _player = new Player();
            _currentDay = _timeManager.InitializeGame();

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
            var day = _timeManager.AdvanceTime(_currentDay);
            // output new day
            Console.WriteLine("Today is now {0} in your {1} week of your {2} year.", _currentDay.CurrentDay, _currentDay.Weeks.ToOrdinal(), _currentDay.Years.ToOrdinal());

        }

        private static void WritePlayerStatus()
        {
            Console.WriteLine(_player.GetStatus());
        }       
    }
}
