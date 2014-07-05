using Rockstar.Components;

namespace Rockstar.Core.Game.Interfaces
{
    public interface ITimeManager
    {

        /// <summary>
        /// Advance to the next day.
        /// </summary>
        /// <returns>The the day advanced to.</returns>
        Today AdvanceDay(Today today);

        Today InitializeGame();


    }
}
