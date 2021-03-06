﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MRSSLib
{
    public class Item
    {
        private string title= "";
        private string link = "";
        private string description = "";

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

            XmlNode item = xmlDocument.CreateElement("item");
            if (!this.title.Equals(""))
            {
                XmlNode titleNode = xmlDocument.CreateElement("title");
                XmlText titleText = xmlDocument.CreateTextNode(this.title);
                titleNode.AppendChild(titleText);
                item.AppendChild(titleNode);
            }
            if (!this.link.Equals(""))
            {
                XmlNode linkNode = xmlDocument.CreateElement("link");
                XmlText linkText = xmlDocument.CreateTextNode(this.link);
                linkNode.AppendChild(linkText);
                item.AppendChild(linkNode);
            }
            if (!this.description.Equals(""))
            {
                XmlNode descriptionNode = xmlDocument.CreateElement("description");
                XmlText descriptionText = xmlDocument.CreateTextNode(this.description);
                descriptionNode.AppendChild(descriptionText);
                item.AppendChild(descriptionNode);
            }
            return item;
        }
    }
}
