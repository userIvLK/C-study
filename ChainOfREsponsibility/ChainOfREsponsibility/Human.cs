namespace ChainOfREsponsibility
{
    public class Human : AbstractHandler
    {
        public override void Handle(Order order)
        {
            if (order.GetTransportPrefs().Contains(TransportationType.human))
            {
                Console.WriteLine("Delivered by human");
            }
            else if (Successor != null)
            {
                Successor.Handle(order);
            }
            else
            {
                Console.WriteLine("Impossible to deliver");
            }
        }
    }
}

