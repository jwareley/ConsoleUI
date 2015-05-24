using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCore.Interfaces
{
    public interface ICGraphics:ICCore
    {
        ICRect ParentCRect { get; set; }
        void Draw(char[] text);
        void Draw(string text);
        void Draw(char text);
        void Draw();
    }
}
