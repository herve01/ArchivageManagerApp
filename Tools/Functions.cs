using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;


namespace ArchiveManagerApp.Util
{
    public class Functions
    {


        public static string ConvertByteArrayToPdf(byte[] pdfData)
        {
            var path = string.Empty;

            try
            {
                // Write the byte array to a file (PDF)
                File.WriteAllBytes(path, pdfData);
                //Console.WriteLine($"PDF saved to {outputPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving PDF: " + ex.Message);
            }
            return path;
        }

        public static string ShowPDF(byte[] pdfData)
        {

            var path = "";

            using (MemoryStream ms = new MemoryStream(pdfData))
            {
                string tempFile = Path.Combine(Path.GetTempPath(), "temp.pdf");

                File.WriteAllBytes(tempFile, ms.ToArray());

                path = tempFile;
            }

            return path;
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

        public static string GetMonthName(int mois)
        {
            SortedList<int, string> months = new SortedList<int, string>();
            months.Add(1, "Janvier");
            months.Add(2, "Février");
            months.Add(3, "Mars");
            months.Add(4, "Avril");
            months.Add(5, "Mai");
            months.Add(6, "Juin");
            months.Add(7, "Juillet");
            months.Add(8, "Août");
            months.Add(9, "Septembre");
            months.Add(10, "Octobre");
            months.Add(11, "Novembre");
            months.Add(12, "Décembre");

            if (mois <= months.Count)
            {
                return months[mois];
            }

            return string.Empty;
        }

        public static string GetMonthNameWithYear(int mois, int annee)
        {
            SortedList<int, string> months = new SortedList<int, string>();
            months.Add(1, "Janvier");
            months.Add(2, "Février");
            months.Add(3, "Mars");
            months.Add(4, "Avril");
            months.Add(5, "Mai");
            months.Add(6, "Juin");
            months.Add(7, "Juillet");
            months.Add(8, "Août");
            months.Add(9, "Septembre");
            months.Add(10, "Octobre");
            months.Add(11, "Novembre");
            months.Add(12, "Décembre");

            if (mois <= months.Count)
            {
                return months[mois] +"_"+ annee.ToString();
            }

            return string.Empty;
        }

        public static int GetKeyMonthYear(string mois)
        {
            SortedList<string, int> months = new SortedList<string, int>();
            months.Add("Janvier", 1);
            months.Add("Février", 2);
            months.Add("Mars", 3);
            months.Add("Avril", 4);
            months.Add("Mai", 5);
            months.Add("Juin", 6);
            months.Add("Juillet", 7);
            months.Add("Août", 8);
            months.Add("Septembre", 9);
            months.Add("Octobre", 10) ;
            months.Add("Novembre", 11);
            months.Add("Décembre", 12);

            return months[mois];
        }

      
        public static List<string> getMonthNames()
        {
            return new List<string>()
            {
                "Janvier",
                "Février",
                "Mars",
                "Avril",
                "Mai",
                "Juin",
                "Juillet",
                "Août",
                "Septembre",
                "Octobre",
                "Novembre",
                "Décembre"
            };
        }


        public static List<string> getMonthNamesAll()
        {
            return new List<string>()
            {
                "Tous",
                "Janvier",
                "Février",
                "Mars",
                "Avril",
                "Mai",
                "Juin",
                "Juillet",
                "Août",
                "Septembre",
                "Octobre",
                "Novembre",
                "Décembre"
            };
        }


        
        public static ObservableCollection<string> Town()
        {

            return new ObservableCollection<string>()
            {
                "Bandundu", "Baraka", "Beni", "Boende", "Boma", "Bukavu",
                "Bumba", "Bunia", "Buta", "Butembo", "Fungurume","Gandajika",
                "Gbadolite", "Gemena", "Goma", "Inga", "Inongo", "Isiro",
                "Kabinda", "Kafubu", "Kalemie", "Kambove", "Kamina", "Kananga", "Kapolowe",
                "Kasumbalesa", "Kenge","Kiela Kalanda", "Kikwit", "Kimpese", "Kindu", 
                "Kinshasa", "Kipushi", "Kisangani", "Kolwezi", "Likasi", "Lubudi", 
                "Lubumbashi", "Lufu", "Lukala", "Matadi", "Mbakana", "Mbandaka",
                "Mbanza-Ngungu", "Mbuji-Mayi", "Muanda", "Mwene-Ditu", "Tshikapa",
                "Uvira", "Zongo"
            };
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
