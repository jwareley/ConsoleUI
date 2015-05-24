using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;

namespace CCoreImpl
{
    public class CHeader: CGraphics,ICHeader
    {
        public static int CHeaderHeight = 3;
        public string HeaderText { get; set; }
        public char LineCharType { get; set; }

        public override void Draw()
        {
            var isPageTitlePrinted = false;
            //Draw Top of Header
            Draw(CharStore.Borders.SingleBorder.LeftTopCornerSingleBorderChar);
            Draw(Enumerable.Repeat(CharStore.Borders.SingleBorder.HorizontalSingleChar, ParentCRect.Width - 2).ToArray());
            Draw(CharStore.Borders.SingleBorder.RightTopCornerSingleBorderChar);

            //Draw Header Text
            Draw(CharStore.Borders.SingleBorder.VerticalSingleChar);
            if (!isPageTitlePrinted)
            {
                Draw(HeaderText);
                Draw(Enumerable.Repeat(' ', ((ParentCRect.Width - 2) - (HeaderText.Length))).ToArray());
                isPageTitlePrinted = true;
            }
            Draw(CharStore.Borders.SingleBorder.VerticalSingleChar);

            //Draw Header Bottom
            Draw(CharStore.Borders.SingleBorder.LeftJunctionSingleBorderChar);
            Draw(Enumerable.Repeat(CharStore.Borders.SingleBorder.HorizontalSingleChar, ParentCRect.Width - 2).ToArray());
            Draw(CharStore.Borders.SingleBorder.RightJunctionSingleBorderChar);
        }
    }
}
