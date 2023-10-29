using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel;
using iText.Kernel.Pdf;
using System.IO;

namespace PdfToText
{
    static class PdfUtil
    {

        // ...

        // ...

        //public static string OldExtractTextFromPdf(string path)
        //{
        //    using (PdfReader reader = new PdfReader(path))
        //    {
        //        StringBuilder text = new StringBuilder();

        //        for (int i = 1; i <= reader.NumberOfPages; i++)
        //        {
        //            text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
        //        }

        //        return text.ToString();
        //    }
        //}


        public static void PdfToText(string path, string outpath)
        {
            using (var strm = File.Open(path, FileMode.Open))
            {
                using (var ostrm = File.Open(outpath, FileMode.Create))
                {
                    using (var reader = new iText.Kernel.Pdf.PdfReader(strm))
                    {
                        var doc = new iText.Kernel.Pdf.PdfDocument(reader);
                        Console.WriteLine(doc.GetNumberOfPages());
                        for (int p = 1; p < doc.GetNumberOfPages(); ++p)
                        {
                            var page = doc.GetPage(p);
                            var contents = page.GetContentBytes();
                            ostrm.Write(contents, 0, contents.Length);
                        }
                    }
                }
            }
        }
    }
}