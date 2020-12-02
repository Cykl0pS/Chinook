namespace Chinook.Contracts.Report.Marketing
{
    public interface IItemStatistic
    {
        IItemSecondary<int> A { get; }
        IItemSecondary<int> B { get; }
    }
}
