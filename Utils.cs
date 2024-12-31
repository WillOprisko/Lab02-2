using System;

public static class Utils
{
    public static bool IsRelativelyEqual(double d1, double d2)
    {
        double margin = Math.Abs(d1 + d2) / 2 * 0.0001;
        double diff   = Math.Abs(d1 - d2);

        return diff < margin ? true : false;
    }

    //public static Tuple<double, double, double, double>(minX, minY, maxX,maxY) GetBoundingBox(List<Point> points)
    //public static Tuple<double, double, double, double> GetBoundingBox(List<Point> points)
    public static (double minX, double minY, double maxX, double maxY)
        GetBoundingBox(List<Point> points)
    {
        (double minX, double minY, double maxX, double maxY) = (Double.MaxValue, Double.MaxValue, Double.MinValue, Double.MinValue);


        foreach (Point p in points)
        {
            minX = p.X < minX ? p.X : minX;
            minY = p.Y < minY ? p.Y : minY;

            maxX = p.X > maxX ? p.X : maxX;
            maxY = p.Y > maxY ? p.Y : maxY;
        }

        return (minX, minY, maxX, maxY); //new Tuple<double, double, double, double>
    }
}


// mixX = p.X when p.X < minX;