namespace Rockstar.Components
{
    public class Today
    {
        public Today(int days, int weeks, int years, Day day)
        {
            Days = days;
            Weeks = weeks;
            Years = years;
            CurrentDay = day;
        }

        /// <summary>
        /// The name of the current day of the week
        /// </summary>
        public Day CurrentDay { get; set; }

        /// <summary>
        /// The number of weeks passed - 1 index based - IE 1 is the first week.
        /// </summary>
        public int Weeks { get; set; }

        /// <summary>
        /// The number of Days passed - 1 index based - IE 1 is the first day.
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// The number of years passed - 1 index based - IE 1 is the first year.
        /// </summary>
        public int Years { get; set; }
    }
}
