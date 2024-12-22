using System;

public struct Point
{
	public double X;
	public double Y;

	public Point(double x, double y)
	{
		this.X = x; 
		this.Y = y;
	}

	public double Distance(Point other)
	{
		double radicand = Math.Pow((this.X - other.X), 2) + Math.Pow((this.Y - other.Y), 2);
		return Math.Sqrt(radicand);
	}

	override public string ToString()
	{
		return $"({X}, {Y})";
	}
}
