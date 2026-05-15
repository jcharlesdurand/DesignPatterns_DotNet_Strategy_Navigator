using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorApplication.Strategies
{
    public class BikeRouteStrategy : IRouteStrategy
    {
        public Route Calculate(Point start, Point end)
        {
            var distance = CalculateDistance(start, end);
            var duration = (int)(distance / 20 * 60); //20km/h average speed
            return new Route(start, end, distance, duration, "Bike");
        }

        public string GetTransportMode() => "Bike";

        private double CalculateDistance(Point a, Point b)
        {
            var dLat = b.Latitude - a.Latitude;
            var dLon = b.Longitude - a.Longitude;
            return Math.Sqrt(dLat * dLat + dLon * dLon) * 111;
        }
    }
}
