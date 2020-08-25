using System;
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
        public void Remove_ItemAtIndex()
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
        
    }
}
