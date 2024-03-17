namespace Csharp_study
{
    internal class Square : AbstractProduct
    {
        public Square(string Color) { color = Color; }
        private readonly string color;
        public override void PrintShape()
        {
            Console.WriteLine("I am square");
        }
        public override void PrintColor()
        {
            Console.WriteLine($"I am {color}");
        }
    }
}
