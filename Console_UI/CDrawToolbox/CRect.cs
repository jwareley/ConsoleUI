using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;

namespace CCoreImpl
{
    public class CRect : ICRect
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public ICPoint StartCPoint { get; set; }
    }
}
