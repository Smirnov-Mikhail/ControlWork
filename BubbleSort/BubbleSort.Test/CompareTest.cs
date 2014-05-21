namespace BubbleSort.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BubbleSortNamespace;

    /// <summary>
    /// Class for testind compare.
    /// </summary>
    [TestClass]
    public class CompareTest
    {
        [TestMethod]
        public void StringLengthIncreaseCompareTest()
        {
            StringLengthIncreaseCompare comp = new StringLengthIncreaseCompare();
            Assert.AreEqual(0, comp.Compare("cat", "cat"));
            Assert.AreEqual(1, comp.Compare("kitty", "cat"));
            Assert.AreEqual(-1, comp.Compare("cat", "kitty"));
        }

        [TestMethod]
        public void StringLengthDownCompareTest()
        {
            StringLengthDownCompare comp = new StringLengthDownCompare();
            Assert.AreEqual(0, comp.Compare("cat", "cat"));
            Assert.AreEqual(-1, comp.Compare("kitty", "cat"));
            Assert.AreEqual(1, comp.Compare("cat", "kitty"));
        }

        [TestMethod]
        public void IntIncreaseCompareTest()
        {
            IntIncreaseCompare comp = new IntIncreaseCompare();
            Assert.AreEqual(0, comp.Compare(0, 0));
            Assert.AreEqual(1, comp.Compare(1, 0));
            Assert.AreEqual(-1, comp.Compare(0, 1));
        }

        [TestMethod]
        public void IntDownCompareTest()
        {
            IntDownCompare comp = new IntDownCompare();
            Assert.AreEqual(0, comp.Compare(0, 0));
            Assert.AreEqual(-1, comp.Compare(1, 0));
            Assert.AreEqual(1, comp.Compare(0, 1));
        }

        [TestMethod]
        public void CharIncreaseCompareTest()
        {
            CharIncreaseCompare comp = new CharIncreaseCompare();
            Assert.AreEqual(0, comp.Compare('a', 'a'));
            Assert.AreEqual(1, comp.Compare('b', 'a'));
            Assert.AreEqual(-1, comp.Compare('a', 'b'));
        }

        [TestMethod]
        public void CharDownCompareTest()
        {
            CharDownCompare comp = new CharDownCompare();
            Assert.AreEqual(0, comp.Compare('a', 'a'));
            Assert.AreEqual(-1, comp.Compare('b', 'a'));
            Assert.AreEqual(1, comp.Compare('a', 'b'));
        }
    }
}
