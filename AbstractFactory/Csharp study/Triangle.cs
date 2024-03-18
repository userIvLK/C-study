namespace Csharp_study
{
    public class Triangle : IAbstractProduct
    {
        public Triangle(string Color) { color = Color; }
        private readonly string color;
        void IAbstractProduct.PrintShape()
        {
            Console.WriteLine("I am triangle");
        }
        void IAbstractProduct.PrintColor()
        {
            Console.WriteLine($"I am {color}");
        }
    }
}
