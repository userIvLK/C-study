namespace Csharp_study
{
    internal abstract class AbstractFactory //Creates 2 types of ojects
    {
        abstract public AbstractProduct CreateSquare();
        abstract public AbstractProduct CreateTriangle();
    }
}
