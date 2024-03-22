namespace ChainOfREsponsibility
{
    public class Drone : AbstractHandler
    {
        public override void Handle(List<TransportationType> tps)
        {
            if (tps.Contains(TransportationType.drone))
            {
                Console.WriteLine("Delivered by drone");
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
