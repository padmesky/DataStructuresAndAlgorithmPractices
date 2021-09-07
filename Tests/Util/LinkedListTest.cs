using DataStructuresAndAlgorithmPractise.Apps.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Tests.Util
{
    [TestClass]
    public class LinkedListTest
    {
        LinkedList<int> testlist = new LinkedList<int>();

        [TestMethod]
        public void TestLinkedListEmpty() 
        {
            Assert.IsTrue(testlist.IsEmpty());
            Assert.AreEqual(0, testlist.Size());
        }

        [TestMethod]
        public void TestInsertFront()
        {
            testlist.InsertFront(0);
            testlist.InsertFront(1);
            Assert.AreEqual(2, testlist.Size());
            Assert.AreEqual(1, testlist.Front());
            Assert.AreEqual(0, testlist.Back());
            testlist.InsertFront(2);
            Assert.AreEqual(3, testlist.Size());
            Assert.AreEqual(2, testlist.Front());
            Assert.AreEqual(0, testlist.Back());

        }

        [TestMethod]
        public void TestInsertBack()
        {
            testlist.InsertEnd(0);
            testlist.InsertEnd(1);
            Assert.AreEqual(2, testlist.Size());
            Assert.AreEqual(1, testlist.Back());
            Assert.AreEqual(0, testlist.Front());
            testlist.InsertEnd(2);
            Assert.AreEqual(3, testlist.Size());
            Assert.AreEqual(2, testlist.Back());
            Assert.AreEqual(0, testlist.Front());
        }

        [TestMethod]
        public void TestRemoveFront()
        {
            testlist.InsertEnd(1);
            testlist.InsertEnd(2);
            testlist.InsertEnd(3);

            Assert.AreEqual(3, testlist.Size());
            Assert.AreEqual(1, testlist.RemoveFront());
            Assert.AreEqual(2, testlist.Size());
        }

        [TestMethod]
        public void TestRemoveEnd()
        {
            testlist.InsertFront(1);
            testlist.InsertFront(2);
            testlist.InsertFront(3);

            Assert.AreEqual(3, testlist.Size());
            Assert.AreEqual(1, testlist.RemoveEnd());
            Assert.AreEqual(2, testlist.Size());
        }
    }
}
