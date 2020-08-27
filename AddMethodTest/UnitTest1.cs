using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListClass;
namespace MyMethodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ConfirmZeroIndex()
        {
            CustomList<int> test = new CustomList<int>();
            int value = 10;
            test.Add(value);

            int actual = test[0];

            Assert.AreEqual(value, actual);
        }

        [TestMethod]
        public void Add_ConfirmLastIndex()
        {
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;

            test.Add(value1);
            test.Add(value2);

            int actual = test[1];

            Assert.AreEqual(value2, actual);
        }
        [TestMethod]
        public void Add_ConfirmCount()
        {
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;

            test.Add(value1);
            test.Add(value2);
            test.Add(value3);

            int actual = test.Count;
            Assert.AreEqual(expected, test.Count);
        }
        [TestMethod]
        public void Add_ConfirmCapacity()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            int expected = 4;

            int actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CapacityOver4()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            customList.Add(1);
            int expected = 8;

            int actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }
        //Remove Test
        [TestMethod]
        public void Remove_ItemAtFirstIndex()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(10);
            customList.Add(2);

            customList.Remove(customList[0]);
            int actual = customList[0];

            int expected = 10;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemAtLastIndex()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            customList.Remove(customList[2]);
            int actual = customList[1];

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_CountOf3()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(6);

            customList.Remove(customList[2]);
            int actual = customList.Count;

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ConfirmCountOf6()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(5);
            customList.Add(5);
            customList.Add(5);
            customList.Add(5);
            customList.Add(5);
            customList.Add(5);

            customList.Remove(customList[3]);
            int actual = customList.Count;

            int expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_SlidesIntoNextIndex()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(5);

            customList.Remove(customList[3]);
            int actual = customList[3];

            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AllIndexSlideIntoNext()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Add(8);
            customList.Add(6);
            customList.Add(5);

            customList.Remove(customList[3]);
            int actual = customList[4];

            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IfNotFound()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Add(8);
            customList.Add(6);
            customList.Add(5);

            customList.Remove(100);
            //suppost to do nothing
            int actual = customList.Count;

            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_PrintToConsole()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Add(8);
            customList.Add(6);
            customList.Add(5);

            string actual = customList.ToString(); // "524865"
            string expected = "524865";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_IfNothing()
        {
            CustomList<int> testList = new CustomList<int>();

            string actual = testList.ToString();
            string expected = "";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Plus_AddTwoList()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);

            CustomList<int> customList2 = new CustomList<int>();
            customList2.Add(8);
            customList2.Add(6);
            customList2.Add(5);

            CustomList<int> actualList = customList + customList2;
            CustomList<int> expectedList = new CustomList<int>();
            expectedList.Add(5);
            expectedList.Add(2);
            expectedList.Add(4);
            expectedList.Add(8);
            expectedList.Add(6);
            expectedList.Add(5);

            string actual = actualList.ToString();
            string expected = expectedList.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Plus_IfListEmpty()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);

            CustomList<int> customList2 = new CustomList<int>();

            CustomList<int> actualList = customList + customList2;
            CustomList<int> expectedList = new CustomList<int>();
            expectedList.Add(5);
            expectedList.Add(2);
            expectedList.Add(4);

            string actual = actualList.ToString();
            string expected = expectedList.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Plus_IfSecondListIsLarger()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(5);
            customList.Add(2);

            CustomList<int> customList2 = new CustomList<int>();
            customList2.Add(9);
            customList2.Add(4);
            customList2.Add(7);
            customList2.Add(1);

            CustomList<int> actualList = customList + customList2;
            CustomList<int> expectedList = new CustomList<int>();
            expectedList.Add(5);
            expectedList.Add(2);
            expectedList.Add(9);
            expectedList.Add(4);
            expectedList.Add(7);
            expectedList.Add(1);

            string actual = actualList.ToString();
            string expected = expectedList.ToString();

            Assert.AreEqual(expected, actual);
        }
        
    }
}
