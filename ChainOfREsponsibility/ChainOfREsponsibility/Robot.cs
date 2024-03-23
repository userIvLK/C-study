namespace ChainOfREsponsibility
{
    public class Robot : AbstractHandler
    {
        public override void Handle(Order order)
        {
            if (order.GetTransportPrefs().Contains(TransportationType.robot))
            {
                Console.WriteLine("Delivered by robot");
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
