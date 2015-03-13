using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRSSLib
{
    public class MediaDescription
    {
        private string content;
        public MediaDescription(string content)
        {
            this.content = content;
        }
        public override string ToString()
        {
            if (this.content.Equals(""))
                return "";
            else
                return "<media:description>" + this.content + "</media:description>";
        }
    }
}
