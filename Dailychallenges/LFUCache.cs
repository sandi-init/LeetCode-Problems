using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
     public class LFUResponse{
            public int Value;
            public int Key;
            public int Count;
        }
    public class LFUCache
    {
        public int Capacity;
        public int head = 0;
        
        Dictionary<int, LinkedListNode<LFUResponse>> LFUcache ;
        Dictionary<int, LinkedList<LFUResponse>> freqList ;
        public LFUCache(int capacity)
        {
            this.Capacity = capacity;
            LFUcache = new Dictionary<int, LinkedListNode<LFUResponse>>();
            freqList= new Dictionary<int, LinkedList<LFUResponse>>();
        }

        public int Get(int key)
        {
            if (Capacity <= 0) {
                return -1;
            }
            if (this.LFUcache.ContainsKey(key)==false) {
                return -1;
            }

            var request = LFUcache[key];
            freqList[request.Value.Count].Remove(request);
            request.Value.Count++;
            if (!freqList.ContainsKey(request.Value.Count)) {
                freqList[request.Value.Count] = new LinkedList<LFUResponse>();
            }
            freqList[request.Value.Count].AddLast(request);

            if(freqList[head].Count == 0)
            {
                head++;
            }
            return request.Value.Value;
        }

        public void Put(int key, int value)
        {
            if (Capacity <= 0){
             return;
            }

            var request = this.Get(key);
            // repeated response just update value itself
            if(request != -1)
            {
                LFUcache[key].Value.Value = value;
                return;
            }
            //reached server size remove the leastly used response
            if(LFUcache.Count == Capacity)
            {
                var leastUsed = freqList[head].First;
                LFUcache.Remove(leastUsed.Value.Key);
                freqList[head].RemoveFirst();
            }
            //new Response
            var newrequest = new LFUResponse { Key = key, Value = value, Count = 1 };
            //first time initialize the freqlist
            if (freqList.ContainsKey(1)==false){ 
                freqList[1] = new LinkedList<LFUResponse>();
            }
            var newNode = freqList[1].AddLast(newrequest);
            LFUcache.Add(key, newNode);
            head = 1;
        }
        public void print(){
            foreach(var dict in LFUcache){
                Console.WriteLine(dict.Key+ " " +dict.Value.Value.Value);
            }
        }
        // public static void Main(String [] args){
        //     LFUCache obj=new LFUCache(2);
        //     obj.Put(2,1);
        //     obj.Put(3,2);
        //     Console.WriteLine(obj.Get(3));
        //     Console.WriteLine(obj.Get(2));
        //     obj.Put(4,3);
        //     Console.WriteLine(obj.Get(2));
        //     Console.WriteLine(obj.Get(3));
        //     Console.WriteLine(obj.Get(4));
        //     // obj.Put(6,6);
        //     // obj.Put(3,3);
        //     obj.print();
        // }
    }
}