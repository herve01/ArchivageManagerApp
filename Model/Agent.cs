using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class Agent : ModelBase
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string PostNom { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public string Mail {  get; set; }
        public byte[] Photo { get; set; }
        public string Fonction { get; set; }
        public string Grade { get; set; }
    }
}
