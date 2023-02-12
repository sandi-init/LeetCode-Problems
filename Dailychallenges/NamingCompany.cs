using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems.Dailychallenges
{
    public class NamingCompany
    {
        public long DistinctNames(string[] ideas) {
            long res = 0;
            HashSet<string>[] maps = new HashSet<string>[26];
            for (int i = 0; i < maps.Length; i++)
                maps[i] = new HashSet<string>();

            foreach (var idea in ideas)
                maps[idea[0] - 'a'].Add(idea);

            long[][] set = new long[26][];
            for (int i = 0; i < set.Length; i++)
                set[i] = new long[26];

            for(int i = 0; i < maps.Length; i++)
            {
                for(int j = 0; j < maps.Length; j++)
                {
                    if (i == j) continue;
                    foreach (var s in maps[j])
                    {
                        var s2 = $"{(char)(i+'a')}" + s.Substring(1);
                        if (!maps[i].Contains(s2)) set[i][j]++;
                    }
                }
            }

            for (int i = 0; i < set.Length; i++)
            {
                for (int j = 0; j < set[0].Length; j++)
                {
                    if (i == j) continue;
                    res += set[i][j] * set[j][i];
                }
            }

            return res;
        }
    }
}