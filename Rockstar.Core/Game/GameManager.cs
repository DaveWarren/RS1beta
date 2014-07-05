using System;
using Rockstar.Core.Game.Interfaces;

namespace Rockstar.Core.Game
{
    public class GameManager : IGameManager
    {
        public int LazeAroundTime()
        {
            var daysToLaze = new Random().Next(1, 7);
            return daysToLaze;
        }
    }
}