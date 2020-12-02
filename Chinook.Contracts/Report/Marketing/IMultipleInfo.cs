namespace Chinook.Contracts.Report.Marketing
{
	public interface IMultipleInfo<T>
	{
		string Name { get; }

		T SecondInfo { get; }
	}
}
