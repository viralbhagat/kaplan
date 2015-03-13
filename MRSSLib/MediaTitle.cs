using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRSSLib
{
    public class MediaTitle
    {
        private string content;

        public MediaTitle(string content)
        {
            this.content = content;
        }
        public override string ToString()
        {
            if (this.content.Equals(""))
                return "";
            else
                return "<media:title>" + this.content+ "</media:title>";
        }
    }
}
