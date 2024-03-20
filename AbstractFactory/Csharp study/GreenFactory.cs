namespace Csharp_study
{
    public class GreenFactory : IAbstractFactory //Creates green family objects
    {
        public IAbstractProduct CreateSquare()
        {
            return new Square("green");
        }

        public IAbstractProduct CreateTriangle()
        {
            return new Triangle("green");
        }
    }
}
