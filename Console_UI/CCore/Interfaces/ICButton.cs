using System;

namespace CCore.Interfaces
{
    public interface ICButton
    {
         ICRect ButtonRect { get; set; }
         string ButtonText { get; set; }
         bool HasTabFocus { get; set; }

         event EventHandler Clicked;
    }
}