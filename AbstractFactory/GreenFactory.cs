namespace Csharp_study
{
    internal class GreenFactory : IAbstractFactory //Creates green family objects
    {
        IAbstractProduct IAbstractFactory.CreateSquare()
        {
            return new Square("green");
        }
        IAbstractProduct IAbstractFactory.CreateTriangle()
        {
            return new Triangle("green");
        }
    }
}
