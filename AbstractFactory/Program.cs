using Csharp_study;

class Program
{
    static void Main(string[] args)
    {
        AbstractFactory RF = new RedFactory();
        AbstractFactory GF = new GreenFactory();
        AbstractProduct RT = RF.CreateTriangle();
        AbstractProduct RS = RF.CreateSquare();
        AbstractProduct GT = GF.CreateTriangle();
        AbstractProduct GS = GF.CreateSquare();

        Console.WriteLine("Red family:");
        Console.WriteLine("\t triangles:");
        RT.PrintColor();
        RT.PrintShape();
        Console.WriteLine("\t squares:");
        RS.PrintColor();
        RS.PrintShape();
        Console.WriteLine("===================");
        Console.WriteLine("Green family:");
        Console.WriteLine("\t triangles:");
        GT.PrintColor();
        GT.PrintShape();
        Console.WriteLine("\t squares:");
        GS.PrintColor();
        GS.PrintShape();
    }
}
