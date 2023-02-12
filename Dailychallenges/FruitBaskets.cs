using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class FruitBaskets
    {
        public int TotalFruit(int[] fruits) {
            int length=fruits.Length;
            Dictionary<int,int> fruitType=new Dictionary<int, int>(length);
            int result=0;
            int startWindow=0;
            for(int i=0;i<length;i++){
                if(!fruitType.TryAdd(fruits[i],1)){
                    fruitType[fruits[i]]+=1;
                }
                while(fruitType.Count>2){
                    fruitType[fruits[startWindow]]-=1;
                    if (fruitType[fruits[startWindow]]==0){
                        fruitType.Remove(fruits[startWindow]);
                    }
                    startWindow++;
                }
                result=Math.Max(result,i-startWindow+1);
            }
            return result;
        }
        // public static void Main(string[] args){
        //     FruitBaskets obj=new FruitBaskets();
        //     int [] fruits={1,2,3,2,2};
        //     Console.WriteLine(obj.TotalFruit(fruits));
        // }
    }
}