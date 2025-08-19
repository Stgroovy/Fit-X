using Fit_X;

static void Main()
{
    Console.WriteLine(" Fit X");
    Console.Write("Input workout type (e.g, Jogging, Cycling): ");
    string type = Console.ReadLine();

    Console.Write("Enter workout duration: ");
    double duration = Console.ReadLine();
      if (duration <= 0)
    {
        Console.Write("Please enter a valid number for duration:");
    }

    Fitness workout = new Fitness(type, duration);

    Console.WriteLine("Workout logged successfully!");
    Console.WriteLine(workout.summary());

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
}


