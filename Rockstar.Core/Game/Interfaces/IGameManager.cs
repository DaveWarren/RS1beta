namespace Rockstar.Core.Game.Interfaces
{
    public interface IGameManager 
    {
        /// <summary>
        /// The player lazes around for a random number of days between 1 & 7.
        /// </summary>
        /// <returns></returns>
        int LazeAroundTime();
    }
}
