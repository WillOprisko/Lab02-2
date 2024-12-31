



internal class Program
{
    // The application exists between the { } of Main //
    private static void Main(string[] args)
    {
        bool keepRunning = true;
        do
        {
            // Menu //
            MainMenu();       
            
            // Capture User Input //
            string choice = String.Empty;
            while (choice.Length != 1 || (!choice.Equals("0") && !choice.Equals("1") && !choice.Equals("2") && !choice.Equals("3") && !choice.Equals("4")))
            {
                Console.Write("Your choice: ");
                choice = Console.ReadLine();
            }


            switch (choice)
            {
                case "0":
                    Console.WriteLine("Rectangle not implemented");
                    // implement Rectangle
                    break;
                case "1":
                    Console.WriteLine("Triangle not implemented");
                    // implement Triangle
                    break;
                case "2":
                    Console.WriteLine("Shape not implemented");
                    // implement Shapes
                    break;
                case "3":
                    keepRunning = false;
                    break;
                case "4":
                    RunTest();
                    break;
            }

        } while (keepRunning);


        EndProgram();
    }
    
    private static void RunTest()
    {
        List<Point> list = new List<Point>();
        //Shape shape;
        //Triangle t;
        Rectangle r;

        /*
        List<Point> list = new List<Point>() { new Point(0, 0), new Point(0, 6), new Point(6, 6), new Point(6, 0) };

        Shape shape = new Shape(list);
        Triangle t;

        Console.WriteLine("Perimeter: {0}", shape.Perimeter());


        list = new List<Point>() { new Point(3, 4), new Point(3, 9), new Point(7, 9), new Point(7, 4) };
        shape = new Shape(list);
        Console.WriteLine(shape.ToString());
        Console.WriteLine("Perimeter: {0}", shape.Perimeter());

        Console.WriteLine();

        list = new List<Point>() { new Point(-2, -2), new Point(-2, 9), new Point(8, 9), new Point(8, -2) };
        shape = new Shape(list);
        Console.WriteLine(shape.ToString());
        Console.WriteLine("Perimeter: {0}", shape.Perimeter());
        */

        Console.WriteLine("- Rectangles -");

        // Rectangle - Two Points
        Rectangle r1 = new Rectangle(new Point(3, 4), new Point(7, 9));
        Console.WriteLine($"R1: {r1}");
        Console.WriteLine($"Perimeter: {r1.Perimeter()}   Area: {r1.Area()}");
       

        Console.WriteLine();

        // Rectangle - Four Points
        Rectangle r2 = new Rectangle(new Point(3, 4), new Point(7, 9), new Point(-2, -2), new Point(8, 1));
        Console.WriteLine($"R2: {r2}");
        Console.WriteLine($"Perimeter: {r2.Perimeter()}   Area: {r2.Area()}");
        

        // Rectangle - List<Point> with Three Points - Working
        /*
        list = new List<Point>() { new Point(-2, -2), new Point(-2, 9), new Point(8, -2) };
        Rectangle r2 = new Rectangle(list);
        Console.WriteLine($"Rectangle: {r2}");
        Console.WriteLine("Perimeter: {0}", r2.Perimeter());
        */


        Console.WriteLine();


        list = new List<Point>() { new Point(1, -4), new Point(9, 1), new Point(3, 4) };
        Triangle t1 = new Triangle(list);
        Console.WriteLine(t1);
        Console.WriteLine($"t1 is scalene? {t1.IsScalene()}");
        Console.WriteLine($"t1 is isosceles? {t1.IsIsosceles()}");
        Console.WriteLine($"Triangle is equilateral? {t1.IsEquilateral()}");
        Console.WriteLine($"Perimeter: {t1.Perimeter()} Area: {t1.Area()}");
        //Console.WriteLine("Perimeter: {0}    Area: {1}", t1.Perimeter(), t1.Area());

        Console.WriteLine();

        list = new List<Point>() { new Point(10, 0), new Point(0, 10), new Point(0, 0) };
        Triangle t2 = new Triangle(list);
        Console.WriteLine(t2);
        Console.WriteLine($"t2 is scalene? {t2.IsScalene()}");
        Console.WriteLine($"t2 is isosceles? {t2.IsIsosceles()}");
        Console.WriteLine($"t3 is equilateral? {t2.IsEquilateral()}");
        Console.WriteLine($"Perimeter: {t2.Perimeter()} Area: {t2.Area()}");
        //Console.WriteLine("Perimeter: {0}    Area: {1}", t2.Perimeter(), t2.Area());

        Console.WriteLine();

        list = new List<Point>() { new Point(0, 0), new Point(10, 0), new Point(5, 8.660254037845) };
        Triangle t3 = new Triangle(list);
        Console.WriteLine(t3);
        Console.WriteLine($"t1 is scalene? {t3.IsScalene()}");
        Console.WriteLine($"t1 is isosceles? {t3.IsIsosceles()}");
        Console.WriteLine($"Triangle is equilateral? {t3.IsEquilateral()}");
        Console.WriteLine($"Perimeter: {t3.Perimeter()} Area: {t3.Area()}");
        //Console.WriteLine("Perimeter: {0}    Area: {1}", t.Perimeter(), t.Area());


        Console.WriteLine("- List of Shapes -");
        Console.WriteLine("Shapes:");
        List<Shape> shapes = new List<Shape>() { r1, r2, t1, t2, t3 };
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s);
            Console.WriteLine($"Perimeter: {s.Perimeter()} Area: {s.Area()}");
        }
        Console.WriteLine();

        Console.WriteLine("Split r1:"); 
        Console.WriteLine($"r1: {r1}");

        Console.WriteLine($"Perimeter: {r1.Perimeter()} Area: {r1.Area()}");
        var triangles = r1.ToTriangles();
        foreach (Triangle t in triangles)
        {
            Console.WriteLine(t);
            Console.WriteLine($"Perimeter: {t.Perimeter()} Area: {t.Area()}");
        }
        double area = triangles[0].Area() + triangles[1].Area();
        Console.WriteLine($"r1 area == combined triangle area?: {Utils.IsRelativelyEqual(area, r1.Area())}");
        /*
        shape = new Triangle(list);
        Console.WriteLine(shape.ToString());
        Console.WriteLine("Perimeter: {0}    Area: {1}", shape.Perimeter(), shape.Area());
        */


        //Point p = new Point(2.65, -9.01);
        //Console.WriteLine(p.ToString());
    }

    private static void MainMenu()
    {
        Console.WriteLine("Please choose from the following menu options.");
        Console.WriteLine("{0,15}", "[0] Rectangle");
        Console.WriteLine("{0,14}", "[1] Triangle");
        Console.WriteLine("{0,11}", "[2] Shape");
        Console.WriteLine("{0,10}", "[3] Exit");
    }
    
    private static void EndProgram()
    {
        Console.WriteLine("Press any key to exit...");
        Console.Read();
    }
}