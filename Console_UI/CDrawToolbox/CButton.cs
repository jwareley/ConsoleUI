using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCore;
using CCore.Interfaces;

namespace CCoreImpl
{
    public class CButton : ICButton
    {
        public ICRect ButtonRect { get; set; }
        public string ButtonText { get; set; }
        public bool HasTabFocus { get; set; }

        public event EventHandler Clicked;
    }
}
