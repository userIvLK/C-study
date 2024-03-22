namespace ChainOfREsponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build an order. Chose how to transport
            List<TransportationType> alltypes = new List<TransportationType>();
            alltypes.Add(TransportationType.robot);
            alltypes.Add(TransportationType.drone);
            alltypes.Add(TransportationType.human);
            Order order1 = new("hat", alltypes);
            Order order2 = new("glass", new List<TransportationType> { TransportationType.human });
            Order order3 = new("glass", new List<TransportationType> { TransportationType.drone, TransportationType.human });
                

            //Set delivery priority
            AbstractHandler HumanH = new Human();
            AbstractHandler DroneH = new Drone();
            AbstractHandler RobotH = new Robot();
            DroneH.Successor = HumanH;
            RobotH.Successor = DroneH; 

            RobotH.Handle(order1.GetTransportPrefs());
            RobotH.Handle(order2.GetTransportPrefs());
            RobotH.Handle(order3.GetTransportPrefs());
          
            
        }
    }
}








