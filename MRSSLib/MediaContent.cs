using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRSSLib
{
    class MediaContent
    {
        private string url;
        private ulong fileSize;
        private string type;
        private int height;
        private int width;
        private int duration;
        private string medium;
        private bool isDefault;

        private MediaTitle mediaTitle;
        private MediaDescription mediaDescription;
        private MediaThumbnail mediaThumbnail;



        public override string ToString()
        {
            return "<media:content url=\"" + this.url + "\" fileSize=\"" + this.fileSize.ToString() + "\" type=\"" + this.type.ToString() + "\" height=\"" + this.height.ToString()
                            + "\" width=\"" + this.width.ToString() + "\" duration=\"" + this.duration.ToString() + "\" medium=\"" + this.medium.ToString() + 
                            "\" isDefault=\"" + this.isDefault.ToString() + "\"" +">" + 
                        this.mediaTitle.ToString() + 
                        this.mediaDescription.ToString() + 
                        this.mediaThumbnail.ToString() + 
                    "</media:content>";
        }
    }
}
