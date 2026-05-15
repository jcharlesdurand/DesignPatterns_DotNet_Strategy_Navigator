using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorApplication.Strategies
{
    public class WalkRouteStrategy : IRouteStrategy
    {
        public Route Calculate(Point start, Point end)
        {
            var distance = CalculateDistance(start, end);
            var duration = (int)(distance / 5 * 60); //5km/h average walking speed
            return new Route(start, end, distance, duration, "Walking");
        }

        public string GetTransportMode() => "Walking";

        private double CalculateDistance(Point a, Point b)
        {
            var dLat = b.Latitude - a.Latitude;
            var dLon = b.Longitude - a.Longitude;
            return Math.Sqrt(dLat * dLat + dLon * dLon) * 111;
        }
    }
}
