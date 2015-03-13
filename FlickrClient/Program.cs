using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FlickrNet;
using MRSSLib;
using System.Xml.Xsl;

namespace FlickrClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string tag;
            if (args.Length > 0)
            {
                tag = args[0];
                Flickr f = new Flickr();
                f.ApiKey = ConfigurationManager.AppSettings.Get("flickrKey");
                PhotoSearchOptions o = new PhotoSearchOptions();
                
                o.Extras = PhotoSearchExtras.AllUrls | PhotoSearchExtras.Description | PhotoSearchExtras.Media;
                o.SortOrder = PhotoSearchSortOrder.Relevance;
                o.Tags = tag;
                PhotoCollection photos = f.PhotosSearch(o);
                var topPhotos = (from p in photos select p).Take(100);

                Document doc = new Document("Kaplan", "www.kaplan.com", "Kaplan - Test assignment");

                foreach (var photo in topPhotos)
                {
                    doc.addItem(photo.Title, photo.SmallUrl, photo.Description);
                }
                doc.SaveDocument( AppDomain.CurrentDomain.BaseDirectory +  "flickr.xml");

                XslTransform myXslTransform;
                myXslTransform = new XslTransform();
                myXslTransform.Load(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\" + "FlickrXSLT.xslt");
                myXslTransform.Transform(AppDomain.CurrentDomain.BaseDirectory + "flickr.xml", AppDomain.CurrentDomain.BaseDirectory  + "output.html"); 
            }
            else
            {
                Console.WriteLine("Tag is not supplied");
            }
        }
    }
}
