namespace SnowSite.UI.Tests.Logger
{
    public interface ILogger
    {
        ILogger WriteLine(string logEntry);
        ILogger BreakLine();
    }
}
