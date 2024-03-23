using StatePattern;
class Program
{
    static void Main(string[] args)
    {
        Elevator MyElevator = new Elevator(new State1());
        MyElevator.Move3();
        MyElevator.Move2();
        MyElevator.Move2();
        MyElevator.Move1();
    }
}