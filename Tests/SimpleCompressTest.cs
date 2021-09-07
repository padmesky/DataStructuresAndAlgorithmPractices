using DataStructuresAndAlgorithmPractise.Apps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DataStructuresAndAlgorithmPractise.Tests
{
    [TestClass]
    public class SimpleCompressTest
    {
        public SimpleCompress simpleCompress = new SimpleCompress();

        [TestMethod]
        public void TestSimpleCompressWithSingleElement()
        {
            Assert.AreEqual("a", simpleCompress.Compress("a"));
        }

        [TestMethod]
        public void TestSimpleCompressWithNonConsecutive()
        {
            Assert.AreEqual("aba", simpleCompress.Compress("aba"));
        }

        [TestMethod]
        public void TestSimpleCompressWithNoRepetation()
        {
            Assert.AreEqual("abcdef", simpleCompress.Compress("abcdef"));
        }

        [TestMethod]
        public void TestSimpleCompress()
        {
            Assert.AreEqual("a2b3cd2ed2f4", simpleCompress.Compress("aabbbcddeddffff"));
        }
    }
}
