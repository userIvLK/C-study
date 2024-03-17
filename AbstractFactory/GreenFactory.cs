namespace Csharp_study
{
    internal class GreenFactory : AbstractFactory //Creates green family objects
    {
        public override AbstractProduct CreateSquare()
        {
            return new Square("green");
        }
        public override AbstractProduct CreateTriangle()
        {
            return new Triangle("green");
        }
    }
}
