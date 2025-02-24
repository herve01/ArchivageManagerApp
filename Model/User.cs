using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class User : ModelBase
    {
        public Agent Agent { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
