using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chinook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingStatisticsController : ControllerBase
    {
        [HttpGet("ArtistStatistics")]
        public IEnumerable<Contracts.Report.Marketing.IArtistStatistic> GetArtistStatistics()
        {
            return Report.MarketingReports.GetArtistStatistics();
        }

        [HttpGet("TrackTimes")]
        public Contracts.Report.Marketing.ITrackTimeStatistic GetTrackTimes()
        {
            return Report.MarketingReports.GetTrackTimes();
        }

        [HttpGet("AlbumTime")]
        public Contracts.Report.Marketing.IAlbumTimeStatistic GetAlbumTime()
        {
            return Report.MarketingReports.GetAlbumTime();
        }

        [HttpGet("TrackSales")]
        public Contracts.Report.Marketing.ITrackSales GetTrackSales()
        {
            return Report.MarketingReports.GetTrackSales();
        }

        [HttpGet("CustomerInfo")]
        public Contracts.Report.Marketing.ICustomersInfo GetCustomerInfo()
        {
            return Report.MarketingReports.GetCustomersInfo();
        }

        [HttpGet("GenresInfo")]
        public Contracts.Report.Marketing.IItemStatistic GetGenresInfo()
        {
            return Report.MarketingReports.GetGenresInfo();
        }
    }
}
