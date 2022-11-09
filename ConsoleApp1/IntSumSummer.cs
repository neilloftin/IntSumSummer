using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IntSumSummer
    {
        //method stub inspired from https://stackoverflow.com/a/39342619
        private static void GetCombinations<T>(List<T> set, List<List<T>> result)
        {
            for (int i = 0; i < set.Count; i++)
            {
                List<T> temp = new List<T>(set.Where((s, index) => index != i));

                if (temp.Count > 0 && !result.Where(l => l.Count == temp.Count).Any(l => l.SequenceEqual(temp)))
                {
                    result.Add(temp);

                    GetCombinations<T>(temp, result);
                }
            }
        }
        private List<List<int>> getSets(List<int> numList)
        {
            List<List<int>> sets = new List<List<int>>();

            if (numList.Count <= 1)
            {
                return new List<List<int>>();
            }
            List<int> baseSet = new List<int>();
            baseSet.AddRange(numList);
            sets.Add(baseSet);// ie, add {1,2,3,4} if we're passed {1,2,3,4} because GetCombinations doesn't return the base set
            GetCombinations<int>(numList, sets);
            
            return sets;
        }

        public int GetSum(List<int> numList)
        {
            var sets = getSets(numList);
            List<int> setSums = new List<int>();

            foreach (var set in sets)
            {
                if (set.Count > 1)
                {
                    if (!setSums.Contains(set.Sum()))
                    {
                        setSums.Add(set.Sum());
                    }
                }
            }

            return setSums.Sum();
        }
    }
}
