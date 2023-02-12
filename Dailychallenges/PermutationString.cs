using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class PermutationString
    {
        public bool CheckInclusion(string s1, string s2) {
        int[] patternMap = new int[26];
        int[] wordMap = new int[26];
        int startWindow = 0;
        for(int i=0;i<s1.Length;i++)
        {
            patternMap[s1[i]-'a']++;
        }
        
        for(int i=0;i<s2.Length;i++)
        {
            wordMap[s2[i]-'a']++;
            if(i-startWindow+1 > s1.Length) 
            {
                wordMap[s2[startWindow++]-'a']--;
            }
            
            if(i-startWindow+1==s1.Length && IsAnagram(patternMap,wordMap)){
                return true;
            }
        }
        
        return false;
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
        // public static void Main(string[] args){
        //     PermutationString obj=new PermutationString();
        //     string s1="ab";
        //     string s2="eidboaoo";
        //     Console.WriteLine(obj.CheckInclusion(s1,s2));
        // }
    }
}