using DataStructuresAndAlgorithmPractise.Apps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DataStructuresAndAlgorithmPractise.Tests
{
    [TestClass]
    public class WarmupTest
    {
        public Warmup warmup = new Warmup();

        [TestMethod]
        public void TestRunningSumOfArrayWithSingleElement() 
        {           
            Assert.IsTrue(warmup.RunningSum(new int[] { 1 }).SequenceEqual(new int[] { 1 }));
        }

        [TestMethod]
        public void TestRunningSumOfArrayAllElementsSame() 
        {
            Assert.IsTrue(warmup.RunningSum(new int[] { 1, 1, 1 }).SequenceEqual(new int[] { 1, 2, 3 }));
        }

        [TestMethod]
        public void TestRunningSumOfArray()
        {
            Assert.IsTrue(warmup.RunningSum(new int[] { 1, 2, 3 , 4}).SequenceEqual(new int[] { 1, 3, 6, 10 }));
        }

        [TestMethod]
        public void TestRunSmallerWithSingleElement() 
        {
            Assert.IsTrue(warmup.NumOfSmaller(new int[] { 1}).SequenceEqual(new int[] {0}));
        }

        [TestMethod]
        public void TestRunSmallerWithAllTheElementsSame()
        {
            Assert.IsTrue(warmup.NumOfSmaller(new int[] { 1,1,1 }).SequenceEqual(new int[] { 0,0,0 }));
        }

        [TestMethod]
        public void TestRunSmallerWithZeroe()
        {
            Assert.IsTrue(warmup.NumOfSmaller(new int[] { 4, 1, 0 }).SequenceEqual(new int[] { 2, 1, 0 }));
        }

        [TestMethod]
        public void TestRunSmaller()
        {
            Assert.IsTrue(warmup.NumOfSmaller(new int[] { 8, 1, 2, 2, 3 }).SequenceEqual(new int[] { 4, 0, 1, 1, 3 }));
        }
    }
}
