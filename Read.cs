class Read
{
	public static void Main(string[] args)
	{
		double num=System.Convert.ToDouble(args[0]);
		double num1=System.Convert.ToDouble(args[1]);

		//System.Console.WriteLine("i:{smallInt}, ii{largeInt}, iii Not less than{smallInt}, iv: Not greater than{largeInt}");
		System.Console.WriteLine("Min Value:{0}", System.Math.Min(num, num1));
		System.Console.WriteLine("Max Value:{0}", System.Math.Max(num, num1));
		System.Console.WriteLine("Not Less Than:{0}", System.Math.Min(num, num1));
		System.Console.WriteLine("Not Greater Than:{0}", System.Math.Max(num, num1));
	}
}