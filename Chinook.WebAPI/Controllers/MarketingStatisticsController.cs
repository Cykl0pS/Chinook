using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chinook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingStatisticsController : ControllerBase
    {
        [HttpGet("api/[controller]/ArtistStatistics")]
        public IEnumerable<Contracts.Report.Marketing.IArtistStatistic> GetArtistStatistics()
        {
            return Report.MarketingReports.GetArtistStatistics();
        }

        [HttpGet("api/[controller]/CustomerInfo")]
        public IEnumerable<Contracts.Report.Marketing.ICustomersInfo> GetCustomerInfo()
        {
            return (IEnumerable<Contracts.Report.Marketing.ICustomersInfo>)Report.MarketingReports.GetCustomersInfo();
        }
    }
}
