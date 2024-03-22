namespace ChainOfREsponsibility
{
    public class Robot : AbstractHandler
    {
        public override void Handle(List<TransportationType> tps)
        {
            if (tps.Contains(TransportationType.robot))
            {
                Console.WriteLine("Delivered by robot");
            }
            else if (Successor != null)
            {
                Successor.Handle(tps);
            }
            else
            {
                Console.WriteLine("Impossible to deliver");
            }
        }
        

    }
}
