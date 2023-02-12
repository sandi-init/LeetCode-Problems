using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class FindAllAnagrams
    {
        public List<int> FindAnagrams(string word, string pat) {
            int length=pat.Length;
            int[] patMap=new int[26];
            int[] wordMap=new int[26];
            int startWindow=0;
            List<int> result=new List<int>();
            for(int i=0;i<length;i++){
                patMap[pat[i]-'a']++;
            }
            for(int i=0;i<word.Length;i++){
                wordMap[word[i]-'a']++;
                if(i-startWindow+1>pat.Length){
                    wordMap[word[startWindow++]-'a']--;
                }
                if(i-startWindow+1==length && IsAnagram(wordMap,patMap)){
                    result.Add(startWindow);
                }
            }
            return result;
        }
        private bool IsAnagram(int[] str1, int[] str2)
    {
        for(int i=0;i<str1.Length;i++)
        {
            if(str1[i] != str2[i]){
                return false;
            } 
        }
        return true;
    }
        // public static void Main(string[] Args){
        //     FindAllAnagrams obj=new FindAllAnagrams();
        //     string word="cbaebabacd";
        //     string pattern="abc";
        //     List<int> ret=obj.FindAnagrams(word,pattern);
        //     foreach(var item in ret){
        //         Console.WriteLine(item);
        //     }
        // }
    }
}