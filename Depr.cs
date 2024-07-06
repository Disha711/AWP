/*1.	The Straight Line Method of computing the yearly depriciation of the value of an item is given by depriciation = (purchase price-Salvage value)/years
 of service. Write a Program to determine the salvage value of an item where the purchase price, years of service and the annual depriciation are given
*/
class Depr
{
	public static void Main(string[] args)
	{
		double p=System.Convert.ToDouble(args[0]); //1000
		
		double y=System.Convert.ToDouble(args[1]);//5
		
		double d=System.Convert.ToDouble(args[2]);//150

		double s=p-(d*y);

		System.Console.WriteLine("{0} units",s);  //250
	}
}
