using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class ItemStatistic : IItemStatistic
    {
        public IItemSecondary<int> A { get; set; }

        public IItemSecondary<int> B { get; set; }
    }
}
