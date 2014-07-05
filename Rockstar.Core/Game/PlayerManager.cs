using System;
using Rockstar.Components;
using Rockstar.Core.Game.Interfaces;

namespace Rockstar.Core.Game
{
    public class PlayerManager : IPlayerManager
    {
        public string GetPlayerStatus(Player player)
        {
            var status = string.Format("Health : {0}\n", player.Health);
            status += string.Format("Creativity : {0}\n", player.Creativity);
            status += string.Format("Happiness : {0}\n", player.Happiness);
            status += string.Format("Alertness : {0}\n", player.Alertness);

            return status;
        }

        
    }
}