namespace IntSumSummerApp
{
    internal class IntSumSummer
    {
        //method inspired from https://stackoverflow.com/a/39342619
        private static void GetCombinations<T>(List<T> set, List<List<T>> result)
        {
            result.Add(set);// below loop doesn't add original set as a valid combination of itself
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
        public int GetSum(List<int> numList)
        {
            var sets = new List<List<int>>();
            GetCombinations<int>(numList, sets);
            List<int> setSums = new List<int>();
            foreach (var set in sets)
            {
                var distinctSet = set.Distinct();
                if (distinctSet.Count() > 1)
                {
                    if (!setSums.Contains(distinctSet.Sum()))
                    {
                        setSums.Add(distinctSet.Sum());
                    }
                }
            }
            return setSums.Sum();
        }
    }
}
