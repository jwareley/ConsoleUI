using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;

namespace CCoreImpl
{
    public class CCentreBorder : CGraphics
    {
        public char BlankChar { get; set; }
        public void Draw()
        {
            Draw(CharStore.Borders.SingleBorder.VerticalSingleChar);
            Draw(Enumerable.Repeat(BlankChar, ParentCRect.Width - 2).ToArray());
            Draw(CharStore.Borders.SingleBorder.VerticalSingleChar);
        }
    }
}
