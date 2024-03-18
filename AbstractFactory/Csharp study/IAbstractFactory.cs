namespace Csharp_study
{
    internal interface IAbstractFactory //Creates 2 types of ojects
    {
        public IAbstractProduct CreateSquare();
        public IAbstractProduct CreateTriangle();
    }
}
