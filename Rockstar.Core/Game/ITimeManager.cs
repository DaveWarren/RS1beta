using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rockstar.Components;


namespace Rockstar.Core.Game
{
    public interface ITimeManager
    {

        /// <summary>
        /// Advance to the next day.
        /// </summary>
        /// <returns>The the day advanced to.</returns>
        Today AdvanceTime(Today today);

        Today InitializeGame();


    }
}
