using System;
using Day01.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Day01.Library.Tests
{
    [TestClass]
    public class CycleProvderTests
    {
        [TestMethod]
        public void Add_OneItem_CurrentItemIsAddedItem()
        {
            ICycleProvider<string> iCycleProvider = new CycleProvider<string>();
            const string testedItem = "Tested Item";

            iCycleProvider.Add(testedItem);

            var actual = iCycleProvider.CurrentItem;

            Assert.AreEqual(testedItem, actual);
        }

        [TestMethod]
        public void Next_Added3Items_AppropriateItemsAreReturned()
        {
            ICycleProvider<string> iCycleProvider = new CycleProvider<string>();
            const string testedItem1 = "Tested Item 1";
            const string testedItem2 = "Tested Item 2";
            const string testedItem3 = "Tested Item 3";

            iCycleProvider.Add(testedItem1);
            iCycleProvider.Add(testedItem2);
            iCycleProvider.Add(testedItem3);

            object actual = iCycleProvider.CurrentItem;

            Assert.AreEqual(testedItem1, actual);

            actual = iCycleProvider.Next();

            Assert.AreEqual(testedItem2, actual);
            Assert.AreEqual(testedItem2, iCycleProvider.CurrentItem);

            actual = iCycleProvider.Next();

            Assert.AreEqual(testedItem3, actual);
            Assert.AreEqual(testedItem3, iCycleProvider.CurrentItem);

            actual = iCycleProvider.Next();

            Assert.AreEqual(testedItem1, actual);
            Assert.AreEqual(testedItem1, iCycleProvider.CurrentItem);
        }
    }
}
