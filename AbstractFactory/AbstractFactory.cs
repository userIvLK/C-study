using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_study
{
    internal abstract class AbstractFactory //Creates 2 types of ojects
    {
        abstract public AbstractProduct createSquare();
        abstract public AbstractProduct createTriangle();
    }
    internal abstract class AbstractProduct 
    {
        abstract public void printShape();
        abstract public void printColor();
    }
    class Square: AbstractProduct  
    {
        public Square(string Color) {color = Color;}
        private string color;
        public override void printShape()
        {
            Console.WriteLine("I am square");
        }
        public override void printColor()
        {
            Console.WriteLine($"I am {color}");
        }
    }
    class Triangle : AbstractProduct
    {
        public Triangle(string Color) { color = Color; }
        private string color;
        public override void printShape()
        {
            Console.WriteLine("I am triangle");
        }
        public override void printColor()
        {
            Console.WriteLine($"I am {color}");
        }
    }
    internal class RedFactory: AbstractFactory //Creates red family objects
    {
        public override AbstractProduct createSquare()
        {
            return new Square("red");
        }
        public override AbstractProduct createTriangle()
        {
            return new Triangle("red");
        }
    }
    internal class GreenFactory : AbstractFactory //Creates green family objects
    {
        public override AbstractProduct createSquare()
        {
            return new Square("green");
        }
        public override AbstractProduct createTriangle()
        {
            return new Triangle("green");
        }
    }
}
