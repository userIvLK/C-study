namespace Csharp_study
{
    public class RedFactory : IAbstractFactory //Creates red family objects
    {
        IAbstractProduct IAbstractFactory.CreateSquare()
        {
            return new Square("red");
        }
        IAbstractProduct IAbstractFactory.CreateTriangle()
        {
            return new Triangle("red");
        }
    }
}
