namespace NavigatorApplication.Strategies
{
    public interface IRouteStrategy
    {
        Route Calculate(Point start, Point end);
        string GetTransportMode();
    }
}