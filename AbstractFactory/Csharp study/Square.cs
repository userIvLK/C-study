namespace Csharp_study
{

    public class Square : IAbstractProduct
    {
        public Square(string Color) { color = Color; }
        private readonly string color;
        public void PrintShape()
        {
            Console.WriteLine("I am square");
        }
        public void PrintColor()
        {
            Console.WriteLine($"I am {color}");
        }
        
    }
}