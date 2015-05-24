using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;

namespace CCoreImpl
{
    public abstract class CGraphics: ICGraphics
    {
        public int Id { get; set; }
        public ICRect ParentCRect { get; set; }
        public virtual void Draw(string text)
        {
            Draw(text.ToArray());
        }
        public virtual void Draw(char text)
        {
            Draw(new char[1] { text });
        }
        public virtual void Draw(char[] text)
        {
            if (ParentCRect != null)
            {
                //Last Char
                if (Console.CursorLeft == ParentCRect.Width - 1 && Console.CursorTop == ParentCRect.Height - 1)
                {
                    Console.Write(text);
                    Console.SetCursorPosition(ParentCRect.StartCPoint.X + 1, CHeader.CHeaderHeight);
                    return;
                }

                //Bottom Row
                if ((Console.CursorTop == ParentCRect.Height - 1) & (Console.CursorLeft != ParentCRect.Width))
                {
                    Console.Write(text);
                    return;
                }

                //Bottom Right
                if ((Console.CursorTop != ParentCRect.Height - 1) & (Console.CursorLeft != ParentCRect.Width))
                {
                    Console.Write(text);
                    return;
                }

                Console.Write(text);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
            }
            else
            {
                Debug.WriteLine("[CGraphics.Draw] Please ensure that you have defined a ParentCRect object before using Draw() method");
            }
          
        }
        public virtual void Draw() { }
        
    }
}
