using System.Collections.Generic;
using DistinctCollection;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class DistinctApi_test
    {
        [Test]
        public void Input_Two_Same_Nums_And_One_Unique_Num_Should_Retun_Two_Unique_Nums()
        {
            var target = new DistinctApi();
            var input = new List<int> { 1, 1, 2 };

            var actual = target.GetDistinct(input);
            var expected = new List<int> { 1, 2 };

            Assert.AreEqual(true, Equals((List<int>)actual, expected));
        }

        private bool Equals(List<int> a, List<int> b)
        {
            if (a == null) return b == null;
            if (b == null || a.Count != b.Count) return false;

            for (int i = 0; i < a.Count; i++)
            {
                if (!Equals(a[i], b[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }


}
