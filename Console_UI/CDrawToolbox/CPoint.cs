using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;

namespace CCoreImpl
{
    public class CPoint : ICPoint
    { 
        public  int X { get; set; }
        public  int Y { get; set; }
        public int Id { get; set; }
    }
}
