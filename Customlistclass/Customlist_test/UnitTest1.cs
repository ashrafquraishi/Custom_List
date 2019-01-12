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
            Assert.AreNotEqual(Expected,intList.Count);

        }

        [TestMethod]
        public void AddStringToMyList_Pass_Test()
        {
            MyList<string> testString = new MyList<string>();

            testString.MyListAdd("cheese");
            testString.MyListAdd("beer");


            Assert.AreEqual("cheese", testString[0]);



        }
    }






 