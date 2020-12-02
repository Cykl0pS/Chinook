using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class TrackSales : ITrackSales
    {
        public double Average { get; set; }

        public IMultipleInfo<int> HighestSales { get; set; }

        public IMultipleInfo<int> LowestSales { get; set; }

        public IMultipleInfo<decimal> HighestRevenue { get; set; }

        public IMultipleInfo<decimal> LowestRevenue { get; set; }
    }
}
