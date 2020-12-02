namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackTimeStatistic
    {
        double Avg { get; set; }

        ITrackTime Max { get; set; }

        ITrackTime Min { get; set; }
    }
}
