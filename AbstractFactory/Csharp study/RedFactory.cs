namespace Csharp_study
{
    public class RedFactory : IAbstractFactory //Creates red family objects
    {
        public IAbstractProduct CreateSquare()
        {
            return new Square("red");
        }
        public IAbstractProduct CreateTriangle() 
        {
            return new Triangle("red");
        }
    }
}
