using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace ArchiveManagerApp.Model.Helper
{
    public class Util
    {
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static string ToMonthName(int month)
        {
            var months = new SortedList<int, string>();

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

            if (month <= months.Count)
            {
                return months[month];
            }

            return string.Empty;
        }

        public static string GetClientIPAddress()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostEntry(hostName);

            foreach (var address in entry.AddressList)
            {
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }

            return string.Empty;
        }

        public static string GetClientMachineName()
        {
            return Environment.MachineName;
        }

        public static string GetMacAddress()
        {
            byte[] macAddress = null;

            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    macAddress = nic.GetPhysicalAddress().GetAddressBytes();
                    break;
                }
            }

            return string.Join(":", macAddress.Select(m => m.ToString("X2")));
        }
        public enum ExtensionType
        {
            PDF,
            IMAGE
        }
    }
}
