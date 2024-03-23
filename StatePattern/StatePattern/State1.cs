namespace StatePattern
{
    public class State1 : IElevatorState
    {
        public void Move1(Elevator elevator)
        {
            Console.WriteLine("Already here");
        }

        public void Move2(Elevator elevator)
        {
            Console.WriteLine("Going up...");
            elevator.Level = new State2();
            Console.WriteLine("Level 2");
        }

        public void Move3(Elevator elevator)
        {
            Console.WriteLine("Going up...");
            elevator.Level = new State3();
            Console.WriteLine("Level 3");
        }
    }
}
