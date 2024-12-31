using System;

public abstract class Shape
{
	// Fields //
	protected List<Point> _Vertices = new List<Point>();

	// Constructors //
	public Shape() 
	{  
	
	}

	public Shape (List<Point> points)
	{
		Vertices = points;
	}

	// Properties //
	public virtual List<Point> Vertices
	{
		get => _Vertices;
		protected set => _Vertices = value;
	}

    // Override Methods //
    override public string ToString()
    {
		String allPoints = string.Join(", ", Vertices);

        return allPoints;
    }

	// Class Methods //
	public abstract double Area();


    public virtual double Perimeter()
	{
		int lastIndex = Vertices.Count - 1;
        double perimeter = 0;

		for (int i = 0; i <= lastIndex; i++)
		{
			if (i == lastIndex)
			{
                perimeter += Vertices[i].Distance(Vertices[0]);
            }
			else
			{
                perimeter += Vertices[i].Distance(Vertices[i + 1]);
            }
		}

		// What is the value in using foreach instead of for-loop?

		return perimeter;
	}

	// Events //

	// Operators //

	// Indexers //

	// Nested Types: Classes, Structs, etc //
}
