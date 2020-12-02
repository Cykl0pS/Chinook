using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class AlbumTimeStatistic : IAlbumTimeStatistic
    {
        public double Avg { get; set; }

        public IAlbumTime Max { get; set; }

        public IAlbumTime Min { get; set; }
    }
}
