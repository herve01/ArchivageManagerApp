using RoadTripAgencyApp.Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class Document : ModelBase
    {
        public byte[] Fichier { get; set; }
        public string Libelle { get; set; }
        public Util.ExtensionType Extension { get; set; }
        public string MotCle { get; set; }
    }
}
