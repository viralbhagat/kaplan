using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRSSLib
{
    public class GUID
    {
        private string content="";
        private bool isPermaLink= false;

        public GUID()
        {
            // TODO: Complete member initialization
        }

        public GUID(string content, bool isPermanentLink)
        {
            this.content = content;
            this.isPermaLink = isPermanentLink;
        }

        
        public override string ToString()
        {
            if (this.content == "")
            {
                return "";
            }
            else
            {
                return "<guid isPermaLink=\"" + this.isPermaLink.ToString().ToLower() + "\">" + this.content + "</guid>";
            }
        }
    }
}
