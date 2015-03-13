using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRSSLib;

namespace MRSSLibUnitTest
{
    [TestClass]
    public class MediaTitleTest
    {
        [TestMethod]
        public void MediaTest_Tag_Generation_WithOutValue()
        {
            var mediaTitle = new MediaTitle("");
            Assert.AreEqual(mediaTitle.ToString(), "");
        }

        [TestMethod]
        public void MediaTitle_Tag_Generation_WithValue()
        {
            var mediaTitle = new MediaTitle("Content");
            Assert.AreEqual(mediaTitle.ToString(), "<media:title>Content</media:title>");

        }
    }
}
