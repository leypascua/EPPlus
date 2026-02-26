using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml.Utils;

namespace EPPlusTest.Utils
{
    [TestClass]
    public class GuardingTests
    {
        private class TestClass
        {

        }

        [TestMethod]
        public void Require_IsNotNull_ShouldThrowIfArgumentIsNull()
        {
            TestClass obj = null;
            Assert.Throws<ArgumentNullException>(() => Require.Argument(obj).IsNotNull("test"));
        }

        [TestMethod]
        public void Require_IsNotNull_ShouldNotThrowIfArgumentIsAnInstance()
        {
            var obj = new TestClass();
            Require.Argument(obj).IsNotNull("test");
        }

        [TestMethod]
        public void Require_IsNotNullOrEmpty_ShouldThrowIfStringIsNull()
        {
            string arg = null;
            Assert.Throws<ArgumentNullException>(() => Require.Argument(arg).IsNotNullOrEmpty("test"));
        }

        [TestMethod]
        public void Require_IsNotNullOrEmpty_ShouldNotThrowIfStringIsNotNullOrEmpty()
        {
            string arg = "test";
            Require.Argument(arg).IsNotNullOrEmpty("test");
        }

        [TestMethod]
        public void Require_IsInRange_ShouldThrowIfArgumentIsOutOfRange()
        {
            int arg = 3;
            Assert.Throws<ArgumentOutOfRangeException>(() => Require.Argument(arg).IsInRange(5, 7, "test"));
        }

        [TestMethod]
        public void Require_IsInRange_ShouldNotThrowIfArgumentIsInRange()
        {
            int arg = 6;
            Require.Argument(arg).IsInRange(5, 7, "test");
        }
    }
}
