using Adapter_pattern;

class Program
{
    static void Main(string[] args)
    {
        Painter Bob = new();
        IDrawingTool pencil = new Pencil();
        IDrawingTool chalk = new Chalk();
        SprayPaint SP = new();
        IDrawingTool sprayPaint = new AdapterToIDrawingTool(SP);

        Bob.Paint();
        Bob.TakeTool(pencil);
        Bob.Paint();
        Bob.TakeTool(chalk); 
        Bob.Paint();
        Bob.TakeTool(sprayPaint);
        Bob.Paint();

    } 
}