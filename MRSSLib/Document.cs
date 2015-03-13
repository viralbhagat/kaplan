using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MRSSLib
{
    public class Document
    {
        private Channel channel = null;
        private XmlDocument document;

        public Document(string title, string link, string description)
        {
            this.document = new XmlDocument();
            this.channel = new Channel(title, link, description, this.document);
        }
        public XmlDocument  GetDocument()
        {
            XmlNode rootNode = document.CreateNode(XmlNodeType.Element, "rss", "http://search.yahoo.com/mrss/");
            XmlAttribute version = document.CreateAttribute("version");
            version.Value = "2.0";
            rootNode.Attributes.Append(version);
            document.AppendChild(rootNode);
            rootNode.AppendChild(this.channel.GetChannelNode());
            return this.document;
        }
        public void addItem(string title, string link, string description)
        {

            this.channel.addItem(title, link, description);
        }
        public void SaveDocument(string path)
        {
            this.GetDocument().Save(path);
        }
    }
}
