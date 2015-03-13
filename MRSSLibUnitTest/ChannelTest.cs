using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRSSLib;
using System.Xml;

namespace MRSSLibUnitTest
{
    [TestClass]
    public class ChannelTest
    {
        [TestMethod]
        public void Channel_Test_CanCreate()
        {
            var Channel = CreateChannel();
            Assert.AreNotEqual(Channel, null);
        }

        [TestMethod]
        public void Channel_Test_Generation()
        {
            var channel = CreateChannel();
            XmlNode nodeGenerated = channel.GetChannelNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 3);

            channel = CreateChannelWithoutTitle();
            nodeGenerated = channel.GetChannelNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 2);

            channel = CreateChannelWithoutLink();
            nodeGenerated = channel.GetChannelNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 2);

            channel = CreateChannelWithoutDescription();
            nodeGenerated = channel.GetChannelNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 2);
        }

        [TestMethod]
        public void Channel_Test_Generation_Values()
        {
            var channel = CreateChannel();
            XmlNode nodeGenerated = channel.GetChannelNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 3);

            Assert.AreEqual(nodeGenerated.ChildNodes[0].ChildNodes[0].Value, "Kaplan");
            Assert.AreEqual(nodeGenerated.ChildNodes[1].ChildNodes[0].Value, "Kaplan Test");
            Assert.AreEqual(nodeGenerated.ChildNodes[2].ChildNodes[0].Value, "This is Kaplan Test");
            
        }


        private static Channel CreateChannel()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var channel = new Channel("Kaplan", "Kaplan Test", "This is Kaplan Test", xmlDocument);
            return channel;
        }

        private static Channel CreateChannelWithoutTitle()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var channel = new Channel("", "Kaplan Test", "This is Kaplan Test", xmlDocument);
            return channel;
        }

        private static Channel CreateChannelWithoutLink()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var channel = new Channel("Kaplan", "", "This is Kaplan Test", xmlDocument);
            return channel;
        }

        private static Channel CreateChannelWithoutDescription()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var channel = new Channel("Kaplan", "Kaplan Test", "", xmlDocument);
            return channel;
        }
    }
}
