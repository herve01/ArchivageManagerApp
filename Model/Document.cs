using ArchiveManagerApp.Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArchiveManagerApp.Model.Helper.Util;

namespace ArchiveManagerApp.Model
{
    public class Document : ModelBase, ICloneable
    {
        public byte[] Fichier { get; set; }
        public string Libelle { get; set; }
        public ExtensionType Extension { get; set; }
        public string MotCle { get; set; }

        public int Index
        {
            get => Dao.AppUtil.Util.ToIndexImageType(Extension.ToString());
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
