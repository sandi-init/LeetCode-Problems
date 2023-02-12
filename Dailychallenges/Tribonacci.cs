
namespace LeetCodeProblems
{
    public class Tribonacci
    {
         public int Tribonaci(int n) {
            List<int> dp=new List<int>(n+1);
            if(n==0){
                return 0;
            }
            if(n==1 || n==2){
                return 1;
            }
            dp.Insert(0,0);
            dp.Insert(1,1);
            dp.Insert(2,1);
            for(int i=3;i<=n;i++){
                int temp=dp[i-1]+dp[i-2]+dp[i-3];
                dp.Insert(i,temp);
            }
            return dp[n];
        }  
        // public static void Main(){
        //     Tribonacci obj =new Tribonacci();
        //     int result=obj.Tribonaci(25);
        //     Console.WriteLine(result);
        // } 
    }
}