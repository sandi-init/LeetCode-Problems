using LeetCodeProblems.Dailychallenges;
namespace LeetCodeProblems
{
    public class Program
    {
        public static void Main(string[] args){
            MinimumFuel obj=new MinimumFuel();
            int[][] roads=new int[3][];
            roads[0]=new int[2]{0,1};
            roads[1]=new int[2]{0,2};
            roads[2]=new int[2]{0,3};
            Console.WriteLine(obj.minimumFuelCost(roads,3));
        }
    }
}