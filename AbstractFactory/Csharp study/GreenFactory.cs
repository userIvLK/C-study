namespace Csharp_study
{
    public class GreenFactory : IAbstractFactory //Creates green family objects
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
