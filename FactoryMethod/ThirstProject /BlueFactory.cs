namespace Csharp_study
{
    public class BlueFactory : IAbstractFactory
    {
        public IAbstractBalloon Create()
        {
            return new BlueBalloon();
        }
    }
}
