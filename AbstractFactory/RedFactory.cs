namespace Csharp_study
{
    internal class RedFactory : AbstractFactory //Creates red family objects
    {
        public override AbstractProduct CreateSquare()
        {
            return new Square("red");
        }
        public override AbstractProduct CreateTriangle()
        {
            return new Triangle("red");
        }
    }
}
