using System;
using System.IO;
using System.Reflection;
using System.Xml.Xsl;

namespace xsltDebugDemo
{
    class Program
    {
        static void Main()
        {
            // Create a new XslCompiledTransform and load the compiled transformation.
            XslCompiledTransform xslt = new XslCompiledTransform(true);  // Enable XSLT debugging.

            // string basePath = Directory.GetCurrentDirectory();
            string basePath = Path.GetDirectoryName(@"../../../");
            var transformFilePath = Path.Combine(basePath, @"Transform.xsl");
            string outputFile = @"below-average.xml";
            
            try
            {
                xslt.Load(transformFilePath);

                // Execute the transformation and output the results to a file.
                // xslt.Transform(Path.Combine(basePath, @"books.xml"), "discount_books.html");
                FileStream outputStream = new FileStream(outputFile, FileMode.Append);
                xslt.Transform(Path.Combine(basePath, @"books.xml"), null, outputStream);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
