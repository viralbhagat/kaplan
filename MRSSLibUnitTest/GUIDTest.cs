using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRSSLib;


namespace MRSSLibUnitTest
{
    [TestClass]
    public class GUIDTest
    {
        [TestMethod]
        public void GUID_Tag_Generation_WithOutValue()
        {
            var guid = new GUID("", true);
            Assert.AreEqual(guid.ToString(), "");

            guid = new GUID();
            Assert.AreEqual(guid.ToString(), "");
        }


        [TestMethod]
        public void GUID_Tag_Generation_WithValue()
        {
            var guid = new GUID("Content", true);
            Assert.AreEqual(guid.ToString(), "<guid isPermaLink=\"true\">Content</guid>");

            guid = new GUID("Content", false);
            Assert.AreEqual(guid.ToString(), "<guid isPermaLink=\"false\">Content</guid>");
        }
    }
}
