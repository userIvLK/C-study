namespace StatePattern
{
    internal class State3 : IElevatorState
    {
        public void Move1(Elevator elevator)
        {
            Console.WriteLine("Going down...");
            elevator.Level = new State1();
            Console.WriteLine("Level 1");
        }

        public void Move2(Elevator elevator)
        {
            Console.WriteLine("Going down...");
            elevator.Level = new State2();
            Console.WriteLine("Level 2");
        }

        public void Move3(Elevator elevator)
        {
            Console.WriteLine("Already here");
        }
    }
}
