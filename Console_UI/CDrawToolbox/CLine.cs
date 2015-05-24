using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;

namespace CCoreImpl
{
    public class CLine : ICLine
    {
        public ICPoint Left { get; set; }
        public ICPoint Right { get; set; }
        public char LineChar { get; set; }
        public CDirection Direction { get; set; }
    }
}
