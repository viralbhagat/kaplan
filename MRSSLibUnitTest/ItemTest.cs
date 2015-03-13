using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRSSLib;
using System.Xml;

namespace MRSSLibUnitTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void Item_Test_CanCreate()
        {
            var item = CreateItem();
            Assert.AreNotEqual(item, null);
        }

        [TestMethod]
        public void Item_Test_Generation()
        {
            var item = CreateItem();
            XmlNode nodeGenerated = item.GetItemNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 3);

            item = CreateItemWithoutTitle();
            nodeGenerated = item.GetItemNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 2);

            item = CreateItemWithoutLink();
            nodeGenerated = item.GetItemNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 2);

            item = CreateItemWithoutDescription();
            nodeGenerated = item.GetItemNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 2);
        }

        public void Item_Test_Generation_Values()
        {
            var item = CreateItem();
            XmlNode nodeGenerated = item.GetItemNode();
            Assert.AreEqual(nodeGenerated.ChildNodes.Count, 3);

            Assert.AreEqual(nodeGenerated.ChildNodes[0].ChildNodes[0].Value, "Kaplan");
            Assert.AreEqual(nodeGenerated.ChildNodes[1].ChildNodes[0].Value, "Kaplan Test");
            Assert.AreEqual(nodeGenerated.ChildNodes[2].ChildNodes[0].Value, "This is Kaplan Test");

        }



        private static Item CreateItem()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var item = new Item("Kaplan", "Kaplan Test", "This is Kaplan Test", xmlDocument);
            return item;
        }

        private static Item CreateItemWithoutTitle()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var item = new Item("", "Kaplan Test", "This is Kaplan Test", xmlDocument);
            return item;
        }

        private static Item CreateItemWithoutLink()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var item = new Item("Kaplan", "", "This is Kaplan Test", xmlDocument);
            return item;
        }

        private static Item CreateItemWithoutDescription()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var item = new Item("Kaplan", "Kaplan Test", "", xmlDocument);
            return item;
        }
    }
}
