using System;

public class Rectangle : Shape
{
    // Fields //
    protected double _Width  = Double.NaN;
    protected double _Height = Double.NaN;

    // Constructors //
    public Rectangle(List<Point> vertices) : base(vertices)
	{

    }

    public Rectangle(Point p1, Point p2 ) : base(new List<Point> { p1, p2 })
    {

    }

    public Rectangle(Point p1, Point p2, Point p3, Point p4) : base(new List<Point> { p1, p2, p3, p4 })
    {

    }


    // Properties //
    override public List<Point>Vertices
    {
        get => base.Vertices;
        protected set
        {
            if(value.Count == 4 || value.Count == 2)
            {
                //Normalize(value);
                base.Vertices = Normalize(value);
            }
            else
            {
                
            }
        }
    }

    public double Width
    {
        get
        {
            if (Vertices.Count > 0)
            {
                var bounds = Utils.GetBoundingBox(Vertices);
                return bounds.maxX - bounds.minX;
            }
            else
            {
                throw new ArgumentException("Rectangle class contains no points.");
            }
        }
    }

    public double Height
    {
        get
        {
            if (Vertices.Count > 0)
            {
                var bounds = Utils.GetBoundingBox(Vertices);
                return bounds.maxY - bounds.minY;
            }
            else
            {
                throw new ArgumentException("Rectangle class contains no points.");
            }
        }
    }

    // Override Methods //
    public override double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"Rectange: {base.ToString()}";
    }

    // Class Methods //
    public bool IsSquare()
    {
        if (Width == Height)
        {
            return true;
        }

        return false;
    }

    public List<Triangle> ToTriangles()
    {
        List<Point> p = Vertices;
        Triangle t1 = new Triangle(p[0], p[1], p[2]);
        Triangle t2 = new Triangle(p[2], p[3], p[0]);

        return new List<Triangle> { t1, t2 };
    }

    private List<Point> Normalize(List<Point> input)
    {
        List<Point> vertices = new List<Point>();
        
        var bounds = Utils.GetBoundingBox(input); // Returns minX, minY, maxX, maxY
        
        vertices.Add(new Point(bounds.minX, bounds.minY));   //bounds.minX, minY
        vertices.Add(new Point(bounds.minX, bounds.maxY));   //minX, maxY
        vertices.Add(new Point(bounds.maxX, bounds.maxY));   //maxX, maxY
        vertices.Add(new Point(bounds.maxX, bounds.minY));   //maxX, minY

        return vertices;
    }

    // Events //

    // Operators //

    // Indexers //

    // Nested Types: Classes, Structs, etc //
}
