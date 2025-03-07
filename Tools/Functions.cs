using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;


namespace ArchiveManagerApp.Util
{
    public class Functions
    {
        public static string GetSizeInMemory(long bytesize)
        {
            string[] sizes = { "o", "Ko", "Mo", "Go", "To" };
            double len = Convert.ToDouble(bytesize);
            int order = 0;
            while (len >= 1024D && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }

            return string.Format(CultureInfo.CurrentCulture, "{0:0.##} {1}", len, sizes[order]);
        }

        public static MemoryStream LoadPdfFromByteArray(byte[] pdfData)
        {
            return new MemoryStream(pdfData);
        }


        public static byte[] ConvertPdfToByteArray(string filePath)
        {
            try
            {
                // Read the PDF file into a byte array
                byte[] pdfBytes = File.ReadAllBytes(filePath);
                return pdfBytes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading PDF file: " + ex.Message);
                return null;
            }
        }
        public static string completeStringByZeros(string chaine)
        {
            return (int.Parse(chaine)).ToString("D5");
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            return table;
        }

        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in list)
            {
                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
