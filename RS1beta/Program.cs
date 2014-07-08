using System;
using System.Reflection;
using Ninject;
using Rockstar.Components;
using Rockstar.Core.Game;
using Rockstar.Core.Game.Interfaces;
using Rockstar.Core.Utilities;

namespace RS1beta
{
    class Program
    {
        private static Player _player;
        private static Today _currentDay;

        private static ITimeManager _timeManager;
        private static IPlayerManager _playerManager;
        private static IGameEngine _gameEngine;

        internal static void Init()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _gameEngine = kernel.Get<IGameEngine>();
        }

        static int Main(string[] args)
        {
            Init();

            _player = new Player();
            _currentDay = _gameEngine.InitializeGame(_player);

            Console.WriteLine("Simulator");
            Console.WriteLine("Enter your band name");
            _player.Name = Console.ReadLine();

            WritePlayerStatus();

            while (_player.NotDead())
            {
                var input = Console.ReadLine();
                switch (input.ToLowerInvariant())
                {
                    case "exit":
                        return 0;

                    case "p":
                        WritePlayerStatus();
                        break;
                    
                    //laze around
                    case "l":
                        _gameEngine.LazeAround();
                        
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
            _currentDay = _timeManager.AdvanceDay(_gameEngine.GetCurrentDay());

            // output new day
            Console.WriteLine("Today is now {0} in your {1} week of your {2} year.", _currentDay.CurrentDay, _currentDay.Weeks.ToOrdinal(), _currentDay.Years.ToOrdinal());
            Console.WriteLine("What do you want to do now? \n [L]aze around a bit.");
        }

        private static void WritePlayerStatus()
        {
            Console.WriteLine(_player.Name);
            Console.WriteLine(_playerManager.GetPlayerStatus(_player));
        }       
    }
}
