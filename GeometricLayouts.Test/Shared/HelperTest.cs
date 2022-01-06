using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLayouts.Shared;

namespace GeometricLayouts.Test.Shared
{
    [TestClass]
    public class HelperTest
    {
        [TestInitialize]
        public void setup()
        {
        }

        [TestMethod]
        public void Check_Valid_Row()
        {
            //arrange
            string row = "B";
            //act
            bool result = Helper.ValidateRow(row);
            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_Invalid_Alphabetic_Row()
        {
            string row = "ABC";
            bool result = Helper.ValidateRow(row);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Check_Out_Of_Range_Row()
        {
            string row = "Z";
            bool result = Helper.ValidateRow(row);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Check_Valid_Column()
        {
            string column = "5";
            bool result = Helper.ValidateColumn(column);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_Invalid_Out_Of_Range_Column()
        {
            string column = "99";
            bool result = Helper.ValidateColumn(column);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Check_Valid_Row_And_Column()
        {
            string rowColumn = "B6";
            bool result = Helper.ValidateRowAndColumn(rowColumn);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_Invalid_Row_And_Column()
        {
            string rowColumn = "5A";
            bool result = Helper.ValidateRowAndColumn(rowColumn);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Check_Split_Row_And_Column()
        {
            string rowColumn = "A5";
            string[] split = {"A", "5"};

            string[] result = Helper.SplitRowAndColumn(rowColumn);

            CollectionAssert.AreEqual(split, result);
        }
    }
}
