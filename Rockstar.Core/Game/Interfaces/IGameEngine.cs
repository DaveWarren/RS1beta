using Rockstar.Components;

namespace Rockstar.Core.Game.Interfaces
{
    public interface IGameEngine 
    {
        /// <summary>
        /// The player lazes around for a random number of days between 1 & 7.
        /// </summary>
        /// <returns></returns>
        void LazeAround();
        
        /// <summary>
        /// Get the current day.
        /// </summary>
        /// <returns>The current day.</returns>
        Today GetCurrentDay();

        Today InitializeGame(Player player, Today currentDay = null);
    }
}
