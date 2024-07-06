class Disp
{
    static void Main(string[] args)
    {
        double U = double.Parse(args[0]);
        double A = double.Parse(args[1]);
        double T = double.Parse(args[2]);
        int numIntervals = int.Parse(args[3]);

        double displacement = U * T + A * T * T / 2;
        double time = numIntervals * T;
        double totalDisplacement = displacement * numIntervals;

        // Using string interpolation with correct placeholder indices
        System.Console.WriteLine("Displacement at {0} seconds: {1}", time, totalDisplacement);
    }
}
