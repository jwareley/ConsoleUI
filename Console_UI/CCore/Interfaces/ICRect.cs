namespace CCore.Interfaces
{
    public interface ICRect
    {
        int Height { get; set; }
        int Width { get; set; }
        ICPoint StartCPoint { get; set; }
    }
}