using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppWithTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithTests.Tests
{
    [TestClass()]
    public class StringHelperTests
    {

        [TestMethod()]
        public void MakeUpperCaseTest_simple()
        {
            // AAA
            string input = "abc";
            string expected = "ABC";

            string actual = StringHelper.MakeUpperCase(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MakeUpperCaseTest_withNumber()
        {
            // AAA
            string input = "abc123";
            string expected = "ABC123";

            string actual = StringHelper.MakeUpperCase(input);

            Assert.AreEqual(expected, actual);
        }
    }
}