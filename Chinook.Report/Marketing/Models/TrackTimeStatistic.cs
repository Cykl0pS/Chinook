namespace Chinook.Report.Marketing.Models
{
    internal class TrackTimeStatistic : Chinook.Contracts.Report.Marketing.ITrackTimeStatistic
    {
        public double Avg { get; set; }

        public Chinook.Contracts.Report.Marketing.ITrackTime Longest { get; set; }

        public Chinook.Contracts.Report.Marketing.ITrackTime Shortest { get; set; }
    }
}
