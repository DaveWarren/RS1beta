using System;
using Rockstar.Components;
using Rockstar.Core.Game.Interfaces;

namespace Rockstar.Core.Game
{
    public class GameEngine : IGameEngine
    {
        private Player _player;
        private Today _currentDay;

        private readonly ITimeManager _timeManager;

        public GameEngine(ITimeManager timeManager)
        {
           
            _timeManager = timeManager;

        }


        public Today InitializeGame(Player player, Today currentDay = null)
        {
            _player = player;
            if(_currentDay != null)
            _currentDay = currentDay ;
            else 
                _currentDay = new Today(1,1,1, Day.Monday);
            return _currentDay;
        }

        public void LazeAround()
        {
            var daysToLaze = new Random().Next(1, 7);
            for (int i = 0; i < daysToLaze; i++)
            {
                _timeManager.AdvanceDay(_currentDay);
                _player.Laze();
            }

        }

        public Today GetCurrentDay()
        {
            return _currentDay;
        }
    }
}