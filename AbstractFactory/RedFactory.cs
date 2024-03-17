namespace Csharp_study
{
    internal class RedFactory : IAbstractFactory //Creates red family objects
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
