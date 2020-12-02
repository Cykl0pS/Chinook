namespace Chinook.Report.Marketing.Models
{
	internal class MultipleInfo<T> : Contracts.Report.Marketing.IMultipleInfo<T>
	{
		public string Name { get; set; }

		public T SecondInfo { get; set; }
	}
}
