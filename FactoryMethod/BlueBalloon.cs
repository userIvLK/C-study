using System.Reflection.Metadata.Ecma335;

namespace Csharp_study
{
    internal class BlueBalloon : IAbstractBalloon
    {
        string IAbstractBalloon.color => "blue"; 
    }
}
