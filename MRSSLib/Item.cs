using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MRSSLib
{
    class Item
    {
        private string title= "";
        private string link = "";
        private string description = "";

        private GUID guid;
        private MediaContent mediaContent;
        private XmlDocument xmlDocument;

        public Item(string title, string link, string description, XmlDocument xmlDocument)
        {
            this.title = title;
            this.link = link;
            this.description = description;
            this.xmlDocument = xmlDocument;
        }



        public XmlNode GetItemNode()
        {

            XmlNode channel = xmlDocument.CreateElement("item");
            if (!this.title.Equals(""))
            {
                XmlNode titleNode = xmlDocument.CreateElement("title");
                XmlText titleText = xmlDocument.CreateTextNode(this.title);
                titleNode.AppendChild(titleText);
                channel.AppendChild(titleNode);
            }
            if (!this.link.Equals(""))
            {
                XmlNode linkNode = xmlDocument.CreateElement("link");
                XmlText linkText = xmlDocument.CreateTextNode(this.link);
                linkNode.AppendChild(linkText);
                channel.AppendChild(linkNode);
            }
            if (!this.description.Equals(""))
            {
                XmlNode descriptionNode = xmlDocument.CreateElement("description");
                XmlText descriptionText = xmlDocument.CreateTextNode(this.description);
                descriptionNode.AppendChild(descriptionText);
                channel.AppendChild(descriptionNode);
            }
            return channel;
        }
    }
}
