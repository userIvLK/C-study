namespace Adapter_pattern
{
    public class Chalk : IDrawingTool
    {
        public void Draw()
        {
            Console.WriteLine("thick colorful line");
        }
    }
}
