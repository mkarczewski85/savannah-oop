using ProjectSavannah.simulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Simulation simulation = new Simulation(100, 100, 20, str => Console.WriteLine(str));
        simulation.Initialize();
        simulation.Run();
    }
}