using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MRSSLib
{
    public class MediaThumbnail
    {
        private string url;
        private int height=0;
        private int width=0;
        private XmlDocument xmlDocument;

        public MediaThumbnail(string url, XmlDocument xmlDocument )
        {
            this.url = url;
            this.xmlDocument = xmlDocument;
        }
        public MediaThumbnail(string url, int height, int width, XmlDocument xmlDocument)
        {
            this.url = url;
            this.height = height;
            this.width = width;
            this.xmlDocument = xmlDocument;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            if (this.url.Equals(""))
                return "";
            else
                output.Append("<media:thumbnail url=\"" + this.url + "\" ");
            if (height > 0)
                output.Append("height=\"" + this.height + "\" ");
            if (width > 0)
                output.Append("width=\"" + this.width + "\" ");
            output.Append(" />");
            return output.ToString();
           
        }
    }
}
