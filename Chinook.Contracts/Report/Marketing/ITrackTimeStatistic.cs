namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackTimeStatistic
    {
        double Avg { get; set; }

        ITrackTime Longest { get; set; }

        ITrackTime Shortest { get; set; }
    }
}
