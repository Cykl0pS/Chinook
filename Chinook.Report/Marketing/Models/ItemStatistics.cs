using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class ItemStatistic : IItemStatistic
    {
        public IMultipleInfo<int> firstItem { get; set; }

        public IMultipleInfo<int> secondItem { get; set; }
    }
}
