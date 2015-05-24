using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Exceptions;
using CCore.Interfaces;
using CCoreImpl;

namespace ConsoleUILib
{
    public class ConsolePage : ICGraphics
    {
        public string PageTitle { get; set; }
        public bool IsCurrentPage { get; set; }
        public ICHeader PageHeader { get; set; }
        public ICStatusBar PageStatusBar { get; set; }
        public ICRect ViewRect { get; set; }
        public ICButton CloseButton { get; set; }
        public bool IsActivePage { get; set; }
        public void Restore(int pageId)
        {
            throw new NotImplementedException();
        }

        public ConsolePage()
        {
           //Initialize();
        }

        public void Initialize(int windowSizeWidth, int WindowSizeHeight)
        {
            var startPoint = new CPoint()
            {
                X = 0,
                Y = 0
            };

            this.ViewRect = new CRect()
            {
                StartCPoint = startPoint,
                Height = Console.LargestWindowHeight,
                Width = Console.LargestWindowWidth
            };

            this.PageHeader = new CHeader
            {
                HeaderText = PageTitle,
                ParentCRect = ViewRect
            };

            this.PageStatusBar = new CStatusBar
            {
                StatusBarText = "Ready",
                ParentCRect = ViewRect
            };

            if (WindowSizeHeight == 0 || windowSizeWidth == 0)
            {
                Console.WindowHeight = ViewRect.Height;
                Console.WindowWidth = ViewRect.Width;
            }
        }


        public void Clear()
        {
            Console.Clear();
        }

        public void Draw()
        {
            if (ViewRect != null)
            {
                DrawBuffer();
            }
            else
            {
                throw new DrawException("No drawing rectangle defined");
            }
        }

        public void DrawBuffer()
        {

            var ccBorder = new CCentreBorder
            {
                BlankChar = CharStore.Characters.BlankSpaceChar,
                ParentCRect = ViewRect
            };

            PageHeader.Draw();
            while (Console.CursorTop != ViewRect.Height - CStatusBar.StatusBarHeight)
            {
                ccBorder.Draw();
            }
            PageStatusBar.Draw();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
        public ICRect ParentCRect { get; set; }
        public void Draw(char[] text)
        {
            throw new NotImplementedException();
        }

        public void Draw(string text)
        {
            throw new NotImplementedException();
        }

        public void Draw(char text)
        {
            throw new NotImplementedException();
        }
    }
}
