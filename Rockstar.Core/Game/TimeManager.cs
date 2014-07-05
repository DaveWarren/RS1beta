using Rockstar.Components;

namespace Rockstar.Core.Game
{
    public class TimeManager : ITimeManager
    {
        public Today AdvanceTime(Today today)
        {
            if (today.CurrentDay == Day.Sunday)
            {
                today.Weeks += 1;
            }

            today.CurrentDay = GetNextDay(today);
            today.Days += 1;

            if (today.Days >= 365)
            {
                today.Years += 1;
                today.Weeks = 1;
                today.Days = 1;
            }

            return today;
        }

        public Today InitializeGame()
        {
            return new Today(1, 1, 1, Day.Monday);
        }

        private Day GetNextDay(Today today)
        {
            switch (today.CurrentDay)
            {
                case Day.Monday:
                    today.CurrentDay = Day.Tuesday;
                    return Day.Tuesday;

                case Day.Tuesday:
                    today.CurrentDay = Day.Wednesday;
                    return Day.Wednesday;

                case Day.Wednesday:
                    today.CurrentDay = Day.Thursday;
                    return Day.Thursday;

                case Day.Thursday:
                    today.CurrentDay = Day.Friday;
                    return Day.Friday;

                case Day.Friday:
                    today.CurrentDay = Day.Saturday;
                    return Day.Saturday;

                case Day.Saturday:
                    today.CurrentDay = Day.Sunday;
                    return Day.Sunday;

                case Day.Sunday:
                    today.CurrentDay = Day.Monday;
                    return Day.Monday;

                default:
                    return Day.Sunday;
            }
        }
    }
}