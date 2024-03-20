namespace Csharp_study
{
    public class Triangle : IAbstractProduct
    {
        public Triangle(string Color) { color = Color; }
        private readonly string color;
        public void PrintShape()
        {
            Console.WriteLine("I am triangle");
        }
        public void PrintColor()
        {
            Console.WriteLine($"I am {color}");
        }
    }
}
