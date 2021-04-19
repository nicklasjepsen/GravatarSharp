using System;
using System.Net.Http;
using GravatarSharp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class GravatarControllerUnitTest
    {
        [TestMethod]
        public void TestGetProfile()
        {
            var controller = new GravatarController(new HttpClient());

            var profileResult = controller.GetProfile(TestCommon.Email).Result;
            Assert.AreEqual(profileResult.Profile.Id, "29792710");
        }

        //[TestMethod]
        //public void TestGetProfile_OtherEmail()
        //{
        //    var controller = new GravatarController();

        //    var profileResult = controller.GetProfile(TestCommon.EmailOther).Result;
        //    Assert.AreEqual(profileResult.Profile.Id, "5123487");
        //}

        [TestMethod]
        public void TestGetProfile_NotFound()
        {
            var controller = new GravatarController(new HttpClient());

            var result = controller.GetProfile("").Result;
            Assert.IsFalse(string.IsNullOrEmpty(result.ErrorMessage));
        }
    }
}
