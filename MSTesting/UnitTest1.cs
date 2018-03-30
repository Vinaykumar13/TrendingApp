using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendingApp;
namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Trending_MSTest_OK()
        {

            var result = Program.WhatsTrending(1);
            Assert.AreEqual("Paul Walker", result);

            result = Program.WhatsTrending(2);
            Assert.AreEqual("Cory Monteith", result);

            result = Program.WhatsTrending(2);
            Assert.AreEqual("Cory Monteith", result);

            result = Program.WhatsTrending(3);
            Assert.AreEqual("RoyalBaby", result);
        }

        /// <summary>
        /// This is to show you how a method look when it fails
        /// </summary>
        [TestMethod]
        public void Test_Trending_MSTest_FAIL()
        {
            var result = Program.WhatsTrending(1);
            Assert.AreEqual("Paul Walker", result);
        }
    }
}
