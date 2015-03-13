using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRSSLib;

namespace MRSSLibUnitTest
{
    [TestClass]
    public class MediaDescriptionTest
    {
        [TestMethod]
        public void MediaDescription_Tag_Generation_WithOutValue()
        {
            var mediaDescription = new MediaDescription("");
            Assert.AreEqual(mediaDescription.ToString(), "");
        }

        [TestMethod]
        public void Description_Tag_Generation_WithValue()
        {
            var mediaDescription = new MediaDescription("Content");
            Assert.AreEqual(mediaDescription.ToString(), "<media:description>Content</media:description>");

        }
    }
}
