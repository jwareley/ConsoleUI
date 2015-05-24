using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;
using CCoreImpl;

namespace CCoreImpl
{
    public class CStatusBar:CGraphics,ICStatusBar
    {
        public static int StatusBarHeight = 3;
            public string StatusBarText { get; set; }
            public ICLine StatusBarLine { get; set; }

        public override void Draw()
        {
            var isPageTitlePrinted = false;
            //Draw Top of StatusBar
            Draw(CharStore.Borders.SingleBorder.LeftJunctionSingleBorderChar);
            Draw(Enumerable.Repeat(CharStore.Borders.SingleBorder.HorizontalSingleChar, ParentCRect.Width - 2).ToArray());
            Draw(CharStore.Borders.SingleBorder.RightJunctionSingleBorderChar);

            //Draw StatusBar Text
            Draw(CharStore.Borders.SingleBorder.VerticalSingleChar);
            if (!isPageTitlePrinted)
            {

                Draw(Enumerable.Repeat(' ', ((ParentCRect.Width - 2) - (StatusBarText.Length))).ToArray());
                Draw(StatusBarText);
                isPageTitlePrinted = true;
            }
            Draw(CharStore.Borders.SingleBorder.VerticalSingleChar);

            //Draw StatusBar Bottom
            Draw(CharStore.Borders.SingleBorder.LeftBottomCornerSingleBorderChar);
            Draw(Enumerable.Repeat(CharStore.Borders.SingleBorder.HorizontalSingleChar, ParentCRect.Width - 2).ToArray());
            Draw(CharStore.Borders.SingleBorder.RightBottomCornerSingleBorderChar);
        }
    }
}
