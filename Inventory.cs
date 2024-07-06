/* In Inventory Management the economic order for the single item is given by EOQ=sqrt(2*demand rate*setup cost)/(holding cost per item per unit time) and 
the optimal time between orders PPO=sqrt(2*setup cost)/(demand rate*holding cost of per item per unit time).
WAP to compute EOQ and PPO, given demand rate(items per unit time), Setup cost(per order), holding cost(per item per unit time).
*/

class Inventory
{
	public static void Main(string[] args)

	{

		double demandRate = double.Parse(args[0]); //100
		double setupCost = double.Parse(args[1]); //50
		double holdingCost = double.Parse(args[2]); //2.5

		double EOQ = System.Math.Sqrt(2* demandRate * setupCost)/holdingCost;
		double PPO = System.Math.Sqrt(2* setupCost )/ (demandRate * holdingCost);

		System.Console.WriteLine("EOQ: {0}", EOQ); //40
		System.Console.WriteLine("PPO: {0}", PPO); //0.04

	}

}