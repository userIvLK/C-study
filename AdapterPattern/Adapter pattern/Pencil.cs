namespace Adapter_pattern
{
    public class Pencil : IDrawingTool
    {
        public void Draw()
        {
            Console.WriteLine("thin black line");
        }
    }
}
