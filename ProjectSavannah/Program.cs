using ProjectSavannah.simulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Simulation simulation = new Simulation(100, 100, 0.1);
        simulation.Initialize();
        simulation.Run();
    }
}