namespace ChainOfREsponsibility
{
    public class Human : AbstractHandler
    {
        public override void Handle(List<TransportationType> tps)
        {
            if (tps.Contains(TransportationType.human))
            {
                Console.WriteLine("Delivered by human");
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

