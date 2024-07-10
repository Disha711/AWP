class Read
{
    public static void Main(string[] args)
    {
        double num = System.Convert.ToDouble(args[0]);
        double num1 = System.Convert.ToDouble(args[1]);

        System.Console.Write("(i)Min Value:{0} (ii)Max Value:{1} (iii)Not Less Than:{2} (iv)Not Greater Than:{3}", 
                             System.Math.Min(num, num1), 
                             System.Math.Max(num, num1), 
                             System.Math.Min(num, num1), 
                             System.Math.Max(num, num1));
    }
}
