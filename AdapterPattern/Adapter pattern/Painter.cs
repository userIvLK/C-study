namespace Adapter_pattern
{
    public class Painter
    {
        private IDrawingTool? toolInHand;
        public void TakeTool(IDrawingTool tool)
        {
            toolInHand = tool;
        }
        public void Paint()
        {
            if(toolInHand == null)
            {
                Console.WriteLine("No tool");
            }
            else
            {
                toolInHand.Draw();
            }
        }
    }
}