
using System;

namespace LeetCodeProblems
{
    public class Player{
        public int score;
        public int age;
    }
    public class BestTeam
    {
        public int[] scores={319776,611683,835240,602298,430007,574,142444,858606,734364,896074};
        public int[] ages={1,1,1,1,1,1,1,1,1,1};
        public List<Player> teamList=new List<Player>();
        // public int[] scores={1,3,5,10,15};
        // public int[] ages={1,2,3,4,5};
        

        public int bestTeam(){
            int length=ages.Length;
            int result=0;
    
            int [] dp=new int[length];
            for(int i=0;i<length;i++){
                var item=new Player{score=scores[i],age=ages[i]};
                teamList.Add(item);
            }
            teamList=teamList.OrderBy(team=>team.age).ThenBy(team=>team.score).ToList();
            for(int i=0;i<length;i++){
                dp[i] = teamList[i].score;
                for(int j = 0; j < i; j++) {
                    if(teamList[j].age==teamList[i].age){
                        dp[i]=Math.Max(dp[i],dp[j]+teamList[i].score);
                    }
                    else if(teamList[j].score <= teamList[i].score && teamList[j].age<teamList[i].age)
                        dp[i] = Math.Max(dp[i], dp[j] + teamList[i].score);
                }
                result = Math.Max(result, dp[i]);
            }
            return result;
        }
        // public static void Main(){
        //     BestTeam obj=new BestTeam();
        //     var result=obj.bestTeam();
        //     // foreach(var item in result){
        //     //     Console.WriteLine(item.age + "=>" +item.score);
        //     // }
        //     Console.WriteLine(result);
        // }
    }
}