using System;

public class Triangle : Shape 
{
    // Fields //

    // Constructors //
    public Triangle(List<Point> points) : base(points)
    {

    }

    public Triangle(Point v1, Point v2, Point v3) : base(new List<Point>() { v1, v2, v3 })
    {

    }


    // Properties //
    override public List<Point> Vertices
    {
        get => base.Vertices;
        protected set
        {
            if (value.Count == 3)
            {
                base.Vertices = value;
            }
            else
            {
                throw new ArgumentException("Triangle class requires three points to instantiate.");
            }            
        }
    }



    // Override Methods //
    override public double Area()
    {
        double s = base.Perimeter() / 2;
        double a = s - Vertices[0].Distance(Vertices[1]);
        double b = s - Vertices[1].Distance(Vertices[2]); 
        double c = s - Vertices[2].Distance(Vertices[0]);

        return Math.Sqrt(s * a * b * c);
    }

    // Class Methods //
    public virtual bool IsEquilateral()
    {
        return TriangleType(3);
    }

    public virtual bool IsIsosceles()
    {
        return TriangleType(1);
    }

    public virtual bool IsScalene()
    {
        return TriangleType(0);
    }

    public bool TriangleType(int sides)
    {
        Double[] sideDistance = new Double[Vertices.Count];
        Boolean[] equalSides = new Boolean[Vertices.Count];

        int sameSides = 0;

        int lastIndex = Vertices.Count - 1;

        for (int i = 0; i <= lastIndex; i++)
        {
            if (i == lastIndex)
            {
                sideDistance[i] = Vertices[i].Distance(Vertices[0]);
            }
            else
            {
                sideDistance[i] = Vertices[i].Distance(Vertices[i + 1]);
            }
        }

        for (int i = 0; i <= lastIndex; i++)
        {
            if (i == lastIndex)
            {
                equalSides[i] = Utils.IsRealativelyEqual(sideDistance[i], sideDistance[0]);
            }
            else
            {
                equalSides[i] = Utils.IsRealativelyEqual(sideDistance[i], sideDistance[i + 1]);
            }

            sameSides += equalSides[i] == true ? 1 : 0;
        }

        if (sides >= 1)
        {
            return sameSides >= sides ? true : false;
        }
        else
        {
            return sameSides == sides ? true : false;
        }              
    }

    // Events //

    // Operators //

    // Indexers //

    // Nested Types: Classes, Structs, etc //
}
