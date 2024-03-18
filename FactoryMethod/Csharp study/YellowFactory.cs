namespace Csharp_study
{
    public class YellowFactory : IAbstractFactory
    {
        public IAbstractBalloon Create()
        {
            return new YellowBalloon();
        }
    }
}
