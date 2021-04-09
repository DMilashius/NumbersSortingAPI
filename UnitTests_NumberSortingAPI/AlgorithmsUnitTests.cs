using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersSortingAPI.Services;

namespace UnitTests_NumberSortingAPI
{
    [TestClass]
    public class AlgorithmsUnitTests
    {
        [TestMethod]
        public void BubbleSort_TestSorting()
        {
            int[] inputArray = new int[] { 200, 142, -4, -9, 20 };
            int[] expectedArray = new int[] { -9, -4, 20, 142, 200 };
            BubbleSort bubbleSort = new BubbleSort();

            var sorted = bubbleSort.Sort(inputArray);

            CollectionAssert.AreEqual(expectedArray, sorted.SortedNumbers);
        }

        [TestMethod]
        public void SelectionSort_TestSorting()
        {
            int[] inputArray = new int[] { 200, 142, -4, -9, 20 };
            int[] expectedArray = new int[] { -9, -4, 20, 142, 200 };
            SelectionSort selectionSort = new SelectionSort();

            var sorted = selectionSort.Sort(inputArray);

            CollectionAssert.AreEqual(expectedArray, sorted.SortedNumbers);
        }
    }
}
