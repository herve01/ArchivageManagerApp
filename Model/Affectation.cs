using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class Affectation : ModelBase
    {
        public Agent Agent { get; set; }
        public Service Service { get; set; }
        public Service OldService { get; set; }
        public DateTime Date { get; set; }
        public bool IsEnd { get; set; }

        public Affectation(Agent agent)
        {
            Agent = agent;
        }
        public Affectation()
        {
            IsEnd = false;
        }
    }
}
