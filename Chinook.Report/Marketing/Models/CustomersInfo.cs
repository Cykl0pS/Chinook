using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class CustomersInfo : ICustomersInfo
    {
        public double Average { get; set; }

        public IMultipleInfo<decimal> TopCustomer { get; set; }

        public IMultipleInfo<decimal> BottomCustomer { get; set; }
    }
}
