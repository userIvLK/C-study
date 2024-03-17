using Csharp_study;

//Пример работы абстрактной фабрики (фабрики создают похожие объекты разных семейств)
class Program
{
    static void Main(string[] args)
    {
        AbstractFactory RF = new RedFactory();
        AbstractFactory GF = new GreenFactory();
        AbstractProduct RT = RF.createTriangle();
        AbstractProduct RS = RF.createSquare();
        AbstractProduct GT = GF.createTriangle();
        AbstractProduct GS = GF.createSquare();

        Console.WriteLine("Red family:");
        Console.WriteLine("\t triangles:");
        RT.printColor();
        RT.printShape();
        Console.WriteLine("\t squares:");
        RS.printColor();
        RS.printShape();
        Console.WriteLine("===================");
        Console.WriteLine("Green family:");
        Console.WriteLine("\t triangles:");
        GT.printColor();
        GT.printShape();
        Console.WriteLine("\t squares:");
        GS.printColor();
        GS.printShape();
    }
}
