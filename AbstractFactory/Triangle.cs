namespace Csharp_study
{
    internal class Triangle : AbstractProduct
    {
        public Triangle(string Color) { color = Color; }
        private readonly string color;
        public override void PrintShape()
        {
            Console.WriteLine("I am triangle");
        }
        public override void PrintColor()
        {
            Console.WriteLine($"I am {color}");
        }
    }
}
