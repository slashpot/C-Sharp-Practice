using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctCollection
{
    public class DistinctApi
    {
        public object GetDistinct(IEnumerable<int> source)
        {
            HashSet<int> hashset = new HashSet<int>();
            GetDistinctHashSetElements(hashset, source);
            int[] distincts = hashset.ToArray<int>();

            var sourceType = source.GetType();
            var result = Activator.CreateInstance(sourceType, distincts);
            return result;
        }

        private void GetDistinctHashSetElements(HashSet<int> hashset, IEnumerable<int> source)
        {
            var enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
                if (!hashset.Contains(enumerator.Current))
                    hashset.Add(enumerator.Current);
        }
    }
}