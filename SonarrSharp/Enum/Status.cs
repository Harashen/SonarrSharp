namespace SonarrSharp.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The series is ongoing
        /// </summary>
        Continuing,

        /// <summary>
        /// The series has ended
        /// </summary>
        Ended,

        /// <summary>
        /// The series has been removed from TVDB (ie Gundam Unicorn)
        /// </summary>
        Deleted,

        /// <summary>
        /// The series is upcoming
        /// </summary>
        Upcoming
    };
}
