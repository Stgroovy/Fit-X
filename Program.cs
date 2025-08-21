using Fit_X;

class Program 
{
    static void Main()
    {
        Console.WriteLine(" Fit X");
        Console.Write("Input workout type (e.g, Jogging, Cycling): ");
        string type = Console.ReadLine();

        Console.Write("Enter workout duration: ");

        //note to self : for console readline to accept any other variable than string it must be converted.

        double duration = double.Parse(Console.ReadLine());
        if (duration <= 0)
        {
            Console.Write("Please enter a valid number for duration:");
        }

        //calling an instance of the fitness method below

        Fitness workout = new Fitness(type, duration);

        Console.WriteLine("Workout logged successfully!");
        Console.WriteLine(workout.Summary());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

}


