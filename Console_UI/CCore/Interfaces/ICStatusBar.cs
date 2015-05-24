using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCore.Interfaces
{
    public interface ICStatusBar:ICGraphics
    {
        string StatusBarText { get; set; }
        ICLine StatusBarLine { get; set; }
     
    }
}
