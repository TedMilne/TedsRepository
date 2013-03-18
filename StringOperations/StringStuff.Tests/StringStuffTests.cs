using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringOperations.Tests
{
    [TestFixture]
    public class StringStuffTests
    {
        [Test]
        public void StringNoSpaceCount_EmptyString_ReturnsZero()
        {
            
            StringStuff strStuff = new StringStuff();
            int result = strStuff.StringNoSpaceCount("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void StringNoSpaceCount_SimpleString_ReturnsOne()
        {
            StringStuff strStuff = new StringStuff();
            int result = strStuff.StringNoSpaceCount("a");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void StringNoSpaceCount_StringWithSpaces_ReturnsSeven()
        {
            StringStuff strStuff = new StringStuff();
            int result = strStuff.StringNoSpaceCount("a    bc   d    e    f                  g");
            Assert.AreEqual(7, result);
        }
    }
}
