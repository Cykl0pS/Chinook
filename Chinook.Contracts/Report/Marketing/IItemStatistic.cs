namespace Chinook.Contracts.Report.Marketing
{
    public interface IItemStatistic
    {
        IMultipleInfo<int> firstItem { get; }
        IMultipleInfo<int> secondItem { get; }
    }
}
