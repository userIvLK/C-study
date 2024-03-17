namespace Csharp_study
{
    internal class YellowFactory : IAbstractFactory
    {
        public IAbstractBalloon Create()
        {
            return new YellowBalloon();
        }
    }
}
