namespace Adapter_pattern
{
    public class AdapterToIDrawingTool : IDrawingTool
    {
        readonly SprayPaint _SP;
        public AdapterToIDrawingTool(SprayPaint SP) { _SP = SP; }
        public void Draw()
        {
            _SP.Spray();
        }
    }
}
