# kaplan
Kaplan code assighment

Thank you very much for this opportunity.

Please clone the repository on yor machine and build the solution.
Afte it is successfully built, open command line and go to  "FlickrClient\bin\Debug".
Following is the command to run the utility.

FlickrClient.ext "tag"

tag can be any keyword to search the images for, e.g. FlickrClient.exe "moon"

While working on this problem, I took references from following pages.

https://www.flickr.com/services/api/

http://www.reelseo.com/how-to-create-mrss/

I am using Flicker .net API dll to query the flickr for images.
After getting image information, I am taking the first 100 images and createdin rss/mrss file.

It is created in "FlickrClient\bin\Debug" with name "flickr.xml".

I am them using "flickrXSLT.xslt" (it is added in the project) to transform the flickr.xml into an html.

The file out put file is "FlickrClient\bin\Debug\output.html". 
After running the program from command line, please open the output.html in browser to see the result.




