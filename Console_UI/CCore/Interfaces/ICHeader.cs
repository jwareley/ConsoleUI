using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCore.Interfaces
{
    public interface ICHeader:ICGraphics
    {
        string HeaderText { get; set; }
        char LineCharType { get; set; }
    }
}
