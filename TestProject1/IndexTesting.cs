using Kata02_BinarySearch.Controller.BinaryFunctions;

namespace TestProject1
{
    public class IndexTesting
    {
        [Fact]
        public void LinearTest()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(0, Finder.IndexByLinear(array, 1));
        }
    }
}