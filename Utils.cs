using System;

public static class Utils
{
    public static bool IsRealativelyEqual(double d1, double d2)
    {
        double margin = Math.Abs(d1 + d2) / 2 * 0.0001;
        double diff   = Math.Abs(d1 - d2);

        return diff < margin ? true : false;
    }

    public static Tuple<double, double, double, double>(minX, minY, maxX,maxY)
        GetBoundingBox(List<Point> points)
    {
        double minX, minY, maxX, maxY;

        for each p in points
        {
            minX = p.X < minX ? p.X : minX;
            minY = p.Y < minY ? p.Y : minY;

            maxX = p.X > maxX ? p.X : maxX;
            maxY = p.Y > minY ? p.Y : minY;
        }

        return new Tuple(minX, minY, maxX, maxY);
    }
}
