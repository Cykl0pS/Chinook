namespace Chinook.Contracts.Report.Marketing
{
	public interface ICustomersInfo
	{
		double Average { get; }

		IMultipleInfo<decimal> TopCustomer { get; }

		IMultipleInfo<decimal> BottomCustomer { get; }
	}
}
