using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_list_class;
namespace Customlist_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_EmptyList_ValueToIndexZero()
        {
            // Arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 0;
            // Act
            numbers.Add(10);
            //Assert
            Assert.AreEqual(expected, numbers[0]);
        }
        [TestMethod]
        public void Add_EmptyList_CountOfOne()
        {
            // Arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            // Act
            numbers.Add(100);
            //Assert
            Assert.AreEqual(expected, numbers.Count);
        }
        [TestMethod]
        public void Remove_IntIncludedInList_OtherIntIsOnlyOneRemaining()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);

            //Assert
            Assert.AreEqual(value1, customList[0]);
        }
        [TestMethod]
        public void Add_TwoInts_CountEqualsTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;
            int expected = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TwoItems_SecondItemGoesToIndexOne()
        {
            // Arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 0;

            // Act
            numbers.Add(100);
            numbers.Add(50);
            //Assert
            Assert.AreEqual(expected, numbers[0]);

        }
        [TestMethod]
        public void RemoveString()
        {
            CustomList<int> intList = new CustomList<int>();
            //Arrange
            int RemoveNumber = 1;
            int Expected = intList.Count;
            intList.Add(5);
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);
            intList.Add(RemoveNumber);
            intList.Remove(RemoveNumber);
            intList.Remove(8);
            // Assert
            Assert.AreNotEqual(Expected, intList.Count);

        }

        [TestMethod]
        public void ToString_OneListOfInts_StringReturned()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 11, 9, 7, 8 };
            string expected = "11, 9, 7, 8";
            //Act
            string actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoIntsToEmptyList_SecondIndexEqualsLastIntAdded()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value1, customList[1]);
        }
        [TestMethod]
        public void Remove_OnlyValueIntInList_ListCountIsZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int expected = 0;

            //Act
            customList.Add(value);
            customList.Remove(value);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneInt_CountIsOneLessThanBefore()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            int value = 22;
            int value1 = 40;
            //Act
            customList.Add(expected);
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_EmptyList_CountEqualsZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            //Act
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_AddAnotherValueToList_CountGoesUpOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 10;
            int value1 = 22;

            int expected = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_RemoveAElementFromList_CountGoesDownOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 10;
            int value1 = 22;

            int expected = 1;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value1);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_RemoveAElementThenAddAnother_CountIsTheSame()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 10;
            int value1 = 22;
            int value2 = 33;

            int expected = 2;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value1);
            customList.Add(value2);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        // *** Indexing Tests ***

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_EmptyListIndexZero_ArgumentOutOfRangeExceptionThrown()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index = 2;
            //Act
            customList.Remove(index);
        }

        [TestMethod]
        public void Indexer_ListWithOneElement_IndexZeroGivesUsTheOneElement()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int index = 0;
            int expected = 11;
            //Act
            customList.Add(expected);
            int actual = customList[index];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}





 