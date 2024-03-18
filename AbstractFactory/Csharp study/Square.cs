namespace Csharp_study
{

    public class Square : IAbstractProduct
    {
        public Square(string Color) { color = Color; }
        private readonly string color;
        void IAbstractProduct.PrintShape()
        {
            Console.WriteLine("I am square");
        }
        void IAbstractProduct.PrintColor()
        {
            Console.WriteLine($"I am {color}");
        }
        
    }
}