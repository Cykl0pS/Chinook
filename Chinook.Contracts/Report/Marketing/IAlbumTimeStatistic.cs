namespace Chinook.Contracts.Report.Marketing
{
    public interface IAlbumTimeStatistic
    {
        double Avg { get; }

        IAlbumTime Max { get; }

        IAlbumTime Min { get; }
    }
}
