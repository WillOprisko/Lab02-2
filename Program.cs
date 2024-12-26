



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

        Console.WriteLine();

        list = new List<Point>() { new Point(1, -4), new Point(9, 1), new Point(3, 4) };
        t = new Triangle(list);
        Console.WriteLine($"Triangle Points: {t}");
        Console.WriteLine($"t1 is scalene? {t.IsScalene()}");
        Console.WriteLine($"t1 is isosceles? {t.IsIsosceles()}");
        Console.WriteLine($"Triangle is equilateral? {t.IsEquilateral()}");
        Console.WriteLine("Perimeter: {0}    Area: {1}", t.Perimeter(), t.Area());

        Console.WriteLine();

        list = new List<Point>() { new Point(10, 0), new Point(0, 10), new Point(0, 0) };
        t = new Triangle(list);
        Console.WriteLine($"Triangle Points: {t}");
        Console.WriteLine($"t1 is scalene? {t.IsScalene()}");
        Console.WriteLine($"t1 is isosceles? {t.IsIsosceles()}");
        Console.WriteLine($"Triangle is equilateral? {t.IsEquilateral()}");
        Console.WriteLine("Perimeter: {0}    Area: {1}", t.Perimeter(), t.Area());

        Console.WriteLine();

        list = new List<Point>() { new Point(0, 0), new Point(10, 0), new Point(5, 8.660254037845) };
        t = new Triangle(list);
        Console.WriteLine($"Triangle Points: {t}");
        Console.WriteLine($"t1 is scalene? {t.IsScalene()}");
        Console.WriteLine($"t1 is isosceles? {t.IsIsosceles()}");
        Console.WriteLine($"Triangle is equilateral? {t.IsEquilateral()}");
        Console.WriteLine("Perimeter: {0}    Area: {1}", t.Perimeter(), t.Area());


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