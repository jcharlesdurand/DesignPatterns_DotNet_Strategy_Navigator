using NavigatorApplication.Strategies;

namespace NavigatorApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paris = new Point(48.8566, 2.3522);
            var lyon = new Point(45.7640, 4.8357);

            var navigator = new Navigator(new CarRouteStrategy());
            navigator.FindRoute(paris, lyon);

            Console.WriteLine();
            navigator.SetStrategy(new BikeRouteStrategy());
            navigator.FindRoute(paris, lyon);

            Console.WriteLine();
            navigator.SetStrategy(new WalkRouteStrategy());
            navigator.FindRoute(paris, lyon);
        }
    }
}
