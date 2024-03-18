using System.Reflection.Metadata.Ecma335;

namespace Csharp_study
{
    public class BlueBalloon : IAbstractBalloon
    {
        string IAbstractBalloon.color => "blue"; 
    }
}
