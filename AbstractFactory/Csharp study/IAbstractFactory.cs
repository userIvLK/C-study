namespace Csharp_study
{
    public interface IAbstractFactory //Creates 2 types of ojects
    {
        public IAbstractProduct CreateSquare();
        public IAbstractProduct CreateTriangle();
    }
}
