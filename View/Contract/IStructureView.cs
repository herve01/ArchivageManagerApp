using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.View.Contract
{
    public interface IStructureView
    {
        void DrawListView();
        void AddItemListView(object obj = null);
    }
}
