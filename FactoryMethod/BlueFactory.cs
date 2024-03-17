namespace Csharp_study
{
    internal class BlueFactory : IAbstractFactory
    {
        public IAbstractBalloon Create()
        {
            return new BlueBalloon();
        }
    }
}
