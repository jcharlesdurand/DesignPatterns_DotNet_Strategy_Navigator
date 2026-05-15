using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorApplication
{
    public record Point(double Latitude, double Longitude);

    public record Route(Point Start, Point End, double DistanceKm, int DurationMinutes, string Mode);
}
