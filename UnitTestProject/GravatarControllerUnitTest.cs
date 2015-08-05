using System;
using GravatarSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class GravatarControllerUnitTest
    {
        [TestMethod]
        public void TestGetUserAgent()
        {
            var controller = new GravatarController();
            var expected = string.Format("GravatarSharp/1.0 ({0}; {1})",
                Environment.OSVersion.Platform, Environment.OSVersion.VersionString);
            Assert.AreEqual(expected,controller.UserAgent);
        }

        [TestMethod]
        public void TestGetProfile()
        {
            var controller = new GravatarController();

            var profileResult = controller.GetProfile(TestCommon.Email).Result;
            Assert.AreEqual(profileResult.Profile.Id, "29792710");
        }

        [TestMethod]
        public void TestGetProfile_OtherEmail()
        {
            var controller = new GravatarController();

            var profileResult = controller.GetProfile(TestCommon.EmailOther).Result;
            Assert.AreEqual(profileResult.Profile.Id, "5123487");
        }

        [TestMethod]
        public void TestGetProfile_NotFound()
        {
            var controller = new GravatarController();

            var result = controller.GetProfile("").Result;
            Assert.IsFalse(string.IsNullOrEmpty(result.ErrorMessage));
        }
    }
}
