using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechnicalTests;

namespace UnitTests
{
    [TestFixture]
    public class SorterAlgorithmTests
    {
        private Sorter _sorter;

        [SetUp]
        public void Init()
        {
            _sorter = new Sorter();
        }

        [TestCase("b,c,a,d,f", "a,b,c,d,f")]
        public void CheckThatBubbleSortCanSortString(string toSort, string expected)
        {
            IList<string> actualResult = _sorter.BubbleSort(toSort.Split(','));

            Assert.AreEqual(expected.Split(','), actualResult);
        }

        [TestCase("10,0,3,9,100", "0,3,9,10,100")]
        public void CheckThatBubbleSortCanSortNumbers(string toSort, string expected)
        {
            Sorter sorter = new Sorter();

            IList<int> actualResult = sorter.BubbleSort<int>(toSort.Split(',').Select(int.Parse).ToArray());

            IEnumerable<int> expectedResult = expected.Split(',').Select(int.Parse);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}