using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class AlbumTimeStatistic : IAlbumTimeStatistic
    {
        public double Avg { get; set; }

        public IAlbumTime Longest { get; set; }

        public IAlbumTime Shortest { get; set; }
    }
}
