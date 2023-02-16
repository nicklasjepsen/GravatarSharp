using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravatarSharp.Tests
{
    [TestClass]
    public class HashingUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NullInput()
        {
            Hashing.CalculateMd5Hash(null);
        }

        [TestMethod]
        public void EmptyStringInput()
        {
            Hashing.CalculateMd5Hash(string.Empty);
        }

        [TestMethod]
        public void TestHashEmail()
        {
            Assert.AreEqual("f561d9206d313b49f9bde3bd50803b84", Hashing.CalculateMd5Hash("nicklas.m.jepsen@gmail.com"));
        }
    }
}
