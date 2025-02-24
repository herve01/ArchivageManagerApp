using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class Service : ModelBase
    {
        public Service()
        {
            Agents = new List<Agent>();
        }
        public string Designation { get; set; }
        public List<Agent> Agents { get; set; } 
    }
}
