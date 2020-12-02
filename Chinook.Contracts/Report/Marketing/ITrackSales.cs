namespace Chinook.Contracts.Report.Marketing
{
	public interface ITrackSales
	{
		double Average { get; }

		IMultipleInfo<int> HighestSales { get; }

		IMultipleInfo<int> LowestSales { get; }

		IMultipleInfo<decimal> HighestRevenue { get; }

		IMultipleInfo<decimal> LowestRevenue { get; }
	}
}
