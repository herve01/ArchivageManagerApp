using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class Archive : ModelBase
    {
        public User User { get; set; }
        public Document Document { get; set; }
        public DateTime Date_Archivage { get; set; }
    }
}
