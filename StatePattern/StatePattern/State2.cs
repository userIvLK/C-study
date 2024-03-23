namespace StatePattern
{
    internal class State2 : IElevatorState
    {
        public void Move1(Elevator elevator)
        {
            Console.WriteLine("Going down...");
            elevator.Level = new State1();
            Console.WriteLine("Level 1");
        }

        public void Move2(Elevator elevator)
        {
            Console.WriteLine("Already here");
        }

        public void Move3(Elevator elevator)
        {
            Console.WriteLine("Going up...");
            elevator.Level = new State3();
            Console.WriteLine("Level 3");
        }
    }
}
