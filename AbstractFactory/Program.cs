using Csharp_study;

class Program
{
    static void Main(string[] args)
    {
        IAbstractFactory RF = new RedFactory();
        IAbstractFactory GF = new GreenFactory();
        IAbstractProduct RT = RF.CreateTriangle();
        IAbstractProduct RS = RF.CreateSquare();
        IAbstractProduct GT = GF.CreateTriangle();
        IAbstractProduct GS = GF.CreateSquare();

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
