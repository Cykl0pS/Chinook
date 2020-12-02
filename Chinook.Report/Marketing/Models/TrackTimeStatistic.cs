namespace Chinook.Report.Marketing.Models
{
    internal class TrackTimeStatistic : Chinook.Contracts.Report.Marketing.ITrackTimeStatistic
    {
        public double Avg { get; set; }

        public Chinook.Contracts.Report.Marketing.ITrackTime Max { get; set; }

        public Chinook.Contracts.Report.Marketing.ITrackTime Min { get; set; }
    }
}
