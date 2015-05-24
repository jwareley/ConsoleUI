using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore.Interfaces;

namespace CCore
{
    public interface IConsolePage:ICGraphics
    {
        string PageTitle { get; set; }
        bool IsCurrentPage { get; set; }
        ICHeader PageHeader { get; set; }
        ICStatusBar PageStatusBar { get; set; }
        ICButton CloseButton { get; set; }
        bool IsActivePage { get; set; }
    }
}
