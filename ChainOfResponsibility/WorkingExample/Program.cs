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


        List<TransportationType> MyTransportation = new List<TransportationType>();
        Console.WriteLine("Name your oreder");
        string? OrderName = Console.ReadLine();
        string? TransType = null;
        for (int i = 0; i<3; i++)
        {
            Console.WriteLine($"Select transportation (option {i+1}) :");
            Console.WriteLine("[1] Robot    [2] Drone   [3] Human   [4] Skip");
            TransType = Console.ReadLine();
            switch (TransType)
            {
                case "1":
                    MyTransportation.Add(TransportationType.robot);
                    break;
                case "2":
                    MyTransportation.Add(TransportationType.drone);
                    break;
                case "3":
                    MyTransportation.Add(TransportationType.human);
                    break;
                case "4":
                    MyTransportation.Add(TransportationType.none);
                    break;
            }
            Console.WriteLine("option added");
            Console.WriteLine("============");
        }
        Console.WriteLine("Delivering");
        Console.WriteLine("============");
        
        OrderName ??= "Unnamed";
        Order MyOrder = new(OrderName, MyTransportation);
        RobotH.Handle(MyOrder.GetTransportPrefs());
        Console.WriteLine(MyOrder.GetContent());

        

    }
}

