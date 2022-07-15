using System;
using System.Collections.Generic;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        public static Point[] GetNeighbors(Point point, int h, params Point[] points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(point));
            }

            if (h <= 0)
            {
                throw new ArgumentException("h-distance is less or equals zero.");
            }

            List<Point> resoult = new List<Point>();
           
            for (int i = 0; i < points.Length; i++)
            {
                if (Math.Abs(points[i].X - point.X) <= h && Math.Abs(points[i].Y - point.Y) <= h)
                {
                    resoult.Add(points[i]);
                }
            }

            return resoult.ToArray();
        }
    }
}
