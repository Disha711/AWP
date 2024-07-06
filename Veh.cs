class Veh
{
	public static void Main(string[] args)
	{
		double u=System.Convert.ToDouble(args[0]); //10
		
		double a=System.Convert.ToDouble(args[1]);//2
		
		double t=System.Convert.ToDouble(args[2]);//5

		double d=u*t+0.5*a*t*t;

		System.Console.WriteLine("Total distance travelled is:{0} meters",d);//75
	}
}