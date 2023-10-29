using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfToText
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pdf_text = PdfUtil.ExtractTextFromPdf(args[0]);
            //using (StreamWriter sw = File.CreateText(args[1]))
            //{
            //    sw.Write(pdf_text);
            //}

            PdfUtil.PdfToText(args[0], args[1]);
        }
    }
}
