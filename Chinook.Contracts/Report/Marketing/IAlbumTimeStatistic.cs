namespace Chinook.Contracts.Report.Marketing
{
    public interface IAlbumTimeStatistic
    {
        double Avg { get; }

        IAlbumTime Longest { get; }

        IAlbumTime Shortest { get; }
    }
}
