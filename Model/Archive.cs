﻿using ArchiveManagerApp.Util;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArchiveManagerApp.Model
{
    public class Archive : ModelBase, ICloneable
    {
        public Archive()
        {
            Document = new Document();
        }
        public User User { get; set; }
        public Document Document { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Document.Libelle +"\n"+ Date.ToString("dd-MM-yyyy à HH:mm") +"\n by"+ User?.Agent?.ToString();
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string[] data
        {
            get => new string[] { "" + this, Document.Libelle, Document.MotCle, Date.ToString("dd-MM-yyyy"), Document.Extension.ToString(), "Agent" };
        }
    }
}
