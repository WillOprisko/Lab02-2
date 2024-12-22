



internal class Program
{
    // The application exists between the { } of Main //
    private static void Main(string[] args)
    {
        //Point p = new Point(2.65, -9.01);
        //Console.WriteLine(p.ToString());

        /*
        bool keepRunning = true;
        do
        {
            // Menu //
           // MainMenu();

            

            
            // Capture User Input //
            string choice = String.Empty;
            while (choice.Length != 1 || (!choice.Equals("0") && !choice.Equals("1") && !choice.Equals("2") && !choice.Equals("3")))
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
            }

        } while (keepRunning);
        */

        EndProgram();
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