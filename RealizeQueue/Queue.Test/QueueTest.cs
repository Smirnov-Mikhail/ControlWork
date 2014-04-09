namespace Queue.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Queue;

    [TestClass]
    public class QueueTest
    {
        [TestInitialize]
        public void Initialize()
        {
            queueInt = new Queue<int>();
            queueChar = new Queue<char>();
        }

        /// <summary>
        /// Test for exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void ExceptionForIntTest()
        {
            queueInt.Dequeue();
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void ExceptionForCharTest()
        {
            queueChar.Dequeue();
        }

        /// <summary>
        /// Test for start empty.
        /// </summary>
        [TestMethod]
        public void TestForEmptyForIntTest()
        {
            Assert.IsTrue(queueInt.TestForEmpty());
        }

        [TestMethod]
        public void TestForEmptyForCharTest()
        {
            Assert.IsTrue(queueChar.TestForEmpty());
        }

        /// <summary>
        /// Test for add in queue.
        /// </summary>
        [TestMethod]
        public void EnqueueForIntTest()
        {
            queueInt.Enqueue(0, 0);
            Assert.IsFalse(queueInt.TestForEmpty());
        }

        [TestMethod]
        public void EnqueueForCharTest()
        {
            queueChar.Enqueue('0', 0);
            Assert.IsFalse(queueChar.TestForEmpty());
        }

        /// <summary>
        /// Test for delete element.
        /// </summary>
        [TestMethod]
        public void DequeueForIntTest()
        {
            queueInt.Enqueue(0, 0);
            queueInt.Dequeue();
            Assert.IsTrue(queueInt.TestForEmpty());
        }

        [TestMethod]
        public void DequeueForCharTest()
        {
            queueChar.Enqueue('0', 0);
            queueChar.Dequeue();
            Assert.IsTrue(queueChar.TestForEmpty());
        }

        /// <summary>
        /// Test for insert with priority.
        /// </summary>
        [TestMethod]
        public void EnqueueForIntWithPriorityTest1()
        {
            queueInt.Enqueue(0, 0);
            queueInt.Enqueue(5, 10);
            queueInt.Enqueue(7, 2);
            Assert.AreEqual(5, queueInt.Dequeue());
        }

        [TestMethod]
        public void EnqueueForCharWithPriorityTest1()
        {
            queueChar.Enqueue('0', 0);
            queueChar.Enqueue('5', 10);
            queueChar.Enqueue('7', 2);
            Assert.AreEqual('5', queueChar.Dequeue());
        }

        /// <summary>
        /// Second test for insert with priority.
        /// </summary>
        [TestMethod]
        public void EnqueueForIntWithPriorityTest2()
        {
            queueInt.Enqueue(0, 2);
            queueInt.Enqueue(5, 2);
            queueInt.Enqueue(7, 1);
            Assert.AreEqual(0, queueInt.Dequeue());
        }

        [TestMethod]
        public void EnqueueForCharWithPriorityTest2()
        {
            queueChar.Enqueue('0', 2);
            queueChar.Enqueue('5', 2);
            queueChar.Enqueue('7', 1);
            Assert.AreEqual('0', queueChar.Dequeue());
        }

        private Queue<int> queueInt;
        private Queue<char> queueChar;
    }
}
