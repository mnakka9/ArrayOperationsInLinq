using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationsOfArrayInLINQ;

namespace ArrayOperationsTest
{
    [TestClass]
    public class UnitTest
    {
        public int[] givenArray { get; set; }

        public UnitTest()
        {
            givenArray = new Int32[] { 1, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 3, 4, 5, 7, 5, 3, 4, 5, 4, 9, 2, 6, 9, 4, 3, 7 };
        }

        [TestMethod]
        public void GetMaxNumberFromArrayTest()
        {
            var expected = 9;
            var actual = LINQArray.GetMaxNoFromArry(givenArray);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSecondMaxNumberFromArrayTest()
        {
            var expected = 8;
            var actual = LINQArray.GetSecondMaxNoFromArry(givenArray);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get5thMaxNumberFromArrayTest()
        {
            var expected = 5;
            var actual = LINQArray.GetNthMaxNoFromArry(givenArray,5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMinNumberFromArrayTest()
        {
            var expected = 1;
            var actual = LINQArray.GetMinNoFromArry(givenArray);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSecondMinNumberFromArrayTest()
        {
            var expected = 2;
            var actual = LINQArray.GetSecondMinNoFromArry(givenArray);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get5thMinNumberFromArrayTest()
        {
            var expected = 5;
            var actual = LINQArray.GetNthMinNoFromArry(givenArray,5);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetPairNumbersWhereSumIsGivenNumberTest()
        {
            var expected = new List<Tuple<int, int>>();
            expected.Add(new Tuple<int, int>(9, 9));
            var actual = LINQArray.GetPairNumbersWhereSumIsGivenNumber(givenArray,18,LINQArray.WayofOperation.Lambda);
            Assert.AreEqual(expected[0], actual[0]);
        }

        [TestMethod]
        public void GetMaxOccurredNumberTest()
        {
            var expected = 9;
            var actual = LINQArray.GetMaxOccurredNumber(givenArray,LINQArray.WayofOperation.Lambda);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSumOfEvenNumbersTest()
        {
            var expected = 42;
            var actual = LINQArray.GetSumOfEvenandOddNumbers(givenArray);
            Assert.AreEqual(expected, actual.Item1);
        }

        [TestMethod]
        public void GetSumOfOddNumbersTest()
        {
            var expected = 123;
            var actual = LINQArray.GetSumOfEvenandOddNumbers(givenArray);
            Assert.AreEqual(expected, actual.Item2);
        }

        [TestMethod]
        public void RotationLeftTest()
        {
            var ArrayNos = new int[] { 1, 2, 3, 4, 5 };
            var rotationNo = 4;
            var expected = "5 1 2 3 4";
            var actual = String.Join(" ", LINQArray.ArrayNumberLeftRotation(ArrayNos, rotationNo));
            Assert.AreEqual(expected, actual);
        }
    }

}
