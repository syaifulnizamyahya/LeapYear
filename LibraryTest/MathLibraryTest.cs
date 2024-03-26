using CommonLibrary;
using System.Diagnostics;

namespace LibraryTest
{
    [TestFixture]
    public class MathLibraryTest
    {
        private static readonly object[] _yearRange =
        {
            new object[] {2000, 2005, new List<int> { 2000, 2004 } },
            new object[] {2090, 2110, new List<int> { 2092, 2096, 2104, 2108 } },
            new object[] {1900, 1905, new List<int> { 1904 } }
        };

        [TestCaseSource(nameof(_yearRange))]
        public void GetLeapYears_YearsStartEnd_ReturnLeapYears(int start, int end, List<int> expected)
        {
            // Arrange 

            // Act
            var actual = MathLibrary.GetLeapYears(start, end);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}