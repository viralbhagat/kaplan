using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MRSSLib
{
    public class Channel
    {
        private string title= "";
        private string link = "";
        private string description = "";

        private List<Item> items = null;
        private XmlDocument xmlDocument;
        public Channel(string title, string link, string description, XmlDocument xmlDocument)
        {
            this.title = title;
            this.link = link;
            this.description = description;
            this.items = new List<Item>();
            this.xmlDocument = xmlDocument;
        }
        public void addItem(string title, string link, string description)
        {
            this.items.Add(new Item(title, link, description, this.xmlDocument));
        }
        public XmlNode GetChannelNode()
        {

            XmlNode channel = xmlDocument.CreateElement("channel");
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
            foreach (var item in this.items)
            {
                channel.AppendChild(item.GetItemNode());
            }
            return channel;
        }

    }
}
