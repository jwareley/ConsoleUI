using CCore.Interfaces;

namespace CCore.Interfaces
{
    public interface ICLine
    {
         ICPoint Left { get; set; }
         ICPoint Right { get; set; }
         char LineChar { get; set; }
         CDirection Direction { get; set; }
    }
}