namespace BubbleSort.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BubbleSortNamespace;  

    /// <summary>
    /// Class for testing sorting.
    /// </summary>
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void IntTest()
        {
            int[] array = { 8, -1, 0, 5 };
            int[] data = { 8, 5, 0, -1 };
            BubbleSort<int>.Sort(ref array, new IntDownCompare());

            for (int i = 0; i < 4; i++)
                Assert.AreEqual(data[i], array[i]);
        }

        [TestMethod]
        public void CharTest()
        {
            char[] array = { 'b', 'a', 'g', '0'};
            char[] data = { '0', 'a', 'b', 'g'};
            BubbleSort<char>.Sort(ref array, new CharIncreaseCompare());

            for (int i = 0; i < 4; i++)
                Assert.AreEqual(data[i], array[i]);
        }

        [TestMethod]
        public void StringTest()
        {
            string[] array = { "adbs5", "io3", "qqqqq6", "I2" };
            string[] data = { "I2", "io3", "adbs5", "qqqqq6" };
            BubbleSort<string>.Sort(ref array, new StringLengthIncreaseCompare());

            for (int i = 0; i < 4; i++)
                Assert.AreEqual(data[i], array[i]);

        }
    }
}
