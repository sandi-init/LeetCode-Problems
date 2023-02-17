using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems.AllProblems
{
    public class LongestValidParentheses
    {
        public int LVP(string s){

            Stack<int> index =new Stack<int>();
            for(int i=0;i < s.Length;i++){
                if (s[i] == '('){
                    index.Push(i);
                }
                else{
                    if(index.Any() && s[index.Peek()] == '('){
                        index.Pop();
                    }
                    else{
                        index.Push(i);
                    }
                }
            }
            if(!index.Any()){
                return s.Length;
            }
            int a = s.Length, b = 0;
            int ans = 0;
            while(index.Any()){
                b = index.Peek();
                index.Pop();
                ans = Math.Max(ans,a-b-1);
                a = b;
            }
            ans = Math.Max(ans,a);
            return ans;
        }
    }
}