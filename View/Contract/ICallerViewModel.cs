using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.View.Contract
{
    public interface ICallerView
    {
        void AddObject(object obj);
        void DeleteObject(object obj);
        void EditObject(object obj);
        bool ContainsObject(object obj);
    }
}
