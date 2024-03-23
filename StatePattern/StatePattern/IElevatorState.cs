namespace StatePattern
{
    public interface IElevatorState
    {
        public void Move1(Elevator elevator);
        public void Move2(Elevator elevator);
        public void Move3(Elevator elevator);
    }
}
