using ChainOfREsponsibility;
class Program
{
    static void Main(string[] args)
    {

        //Set delivery priority
        AbstractHandler HumanH = new Human();
        AbstractHandler DroneH = new Drone();
        AbstractHandler RobotH = new Robot();
        DroneH.Successor = HumanH;
        RobotH.Successor = DroneH;


        Reciever Bob = new("Bob", new List<TransportationType> { TransportationType.human, TransportationType.drone });
        Order BobsOrder = Bob.MakeAnOrder("hat");
        RobotH.Handle(BobsOrder);
        


    }
}

