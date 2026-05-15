using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigatorApplication.Strategies;

namespace NavigatorApplication
{
    public class Navigator 
    {
        private IRouteStrategy _strategy;

        public Navigator(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public Route FindRoute(Point start, Point end)
        {
            Console.WriteLine($"Calculating route by {_strategy.GetTransportMode()}");
            var route = _strategy.Calculate(start, end);
            Console.WriteLine($"  Distance: {route.DistanceKm:F1} km");
            Console.WriteLine($"  Duration: {route.DurationMinutes} minutes");
            return route;
        }
    }
}
