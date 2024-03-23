namespace ChainOfREsponsibility
{
    public class Drone : AbstractHandler
    {
        public override void Handle(Order order)
        {
            if (order.GetTransportPrefs().Contains(TransportationType.drone))
            {
                Console.WriteLine("Delivered by drone");
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
