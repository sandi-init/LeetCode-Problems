using LeetCodeProblems.AllProblems;
namespace LeetCodeProblems
{
    public class Program
    {
        public static void Main(string[] args){
            LongestValidParentheses obj = new LongestValidParentheses();
            int result = obj.LVP(")(()()))(");
            Console.WriteLine(result);
        }
    }
}