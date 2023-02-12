using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Alien953
    {
        //compare two string are in sorted order according to alien language order
        public bool CompareTo(string word1,string word2,int[] order){
            int len1=word1.Length;
            int len2=word2.Length;
            int i=0;
            int minLength=len1<len2?len1:len2;
            while(i<minLength){
                if(word1[i]==word2[i]){
                    i+=1;
                    if(i==len1){
                        return true;
                    }
                }
                else if(order[word1[i]-'a']<order[word2[i]-'a']){
                    return true;
                }
                else{
                    return false;
                }
            }
            return false;
        }
        public bool IsAlienSorted(string[] words, string order) {
            //Get the length of words
            int length=words.Length;
           //Storing th index for finding the words are in sorted order
            int[] indexOrder=new int[26];
            //if only one word is present return true
            if(length==1){
                return true;
            }
            List<int> arr=new List<int>(2);
            // iterate through end of order string and store the index as actual index value of alphabet and value is  postion of alphabet in order string ;
            for(int i=0;i<order.Length;i++){
                indexOrder[order[i]-'a']=i;
            }
            // compare the every two words are in sorted order
            for(int i=1;i<length;i++){
                if(!CompareTo(words[i-1],words[i],indexOrder)){
                    return false;
                }
            }
            return true;
        }
        // public static void Main(string []args){
        //     Alien953 obj =new Alien953();
        //     string order="ngxlkthsjuoqcpavbfdermiywz";
        //     string[] words={"kuvp","q"};
        //     Console.WriteLine(obj.IsAlienSorted(words,order));
        //     // Console.WriteLine(order[0]-'a');
        // }
    }
}