using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Tools
{
    public static class ArchiveDocumentConvert
    {
        public static PdfiumViewer.PdfDocument ConvertByteToPDF(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                throw new ArgumentException("Les données du PDF ne peuvent pas être nulles ou vides.", nameof(bytes));

            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return PdfDocument.Load(stream);
            }
        }
        public static byte[] ReadPdfFileAsBytes(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Fichier PDF introuvable.", filePath);

            return File.ReadAllBytes(filePath);
        }
        public static WordprocessingDocument ConvertByteToWord(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                throw new ArgumentException("Les données du document ne peuvent pas être nulles ou vides.", nameof(bytes));

            MemoryStream stream = new MemoryStream(bytes);
            return WordprocessingDocument.Open(stream, true);
        }
        public static byte[] ConvertWordToByte(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Fichier Word introuvable.", filePath);

            return File.ReadAllBytes(filePath);
        }
        public static string ConvertWordToText(WordprocessingDocument wordDoc)
        {
            if (wordDoc == null)
                throw new ArgumentNullException(nameof(wordDoc), "Le document Word ne peut pas être null.");

            Body body = wordDoc.MainDocumentPart.Document.Body;
            return body?.InnerText ?? string.Empty;
        }

        public static byte[] ConvertImageToByte(Image image)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "L'image ne peut pas être null.");

            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Jpeg); // Format JPG par défaut
                return stream.ToArray();
            }
        }
        public static Image ConvertByteToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                throw new ArgumentException("Les données de l'image ne peuvent pas être nulles ou vides.", nameof(bytes));
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
