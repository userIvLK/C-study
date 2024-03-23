namespace StatePattern;
public class Elevator
{
    public IElevatorState Level { get; set; }
    public Elevator(IElevatorState Level)
    {
        this.Level = Level;
    }
    public void Move1() { Level.Move1(this); }
    public void Move2() { Level.Move2(this); }
    public void Move3() { Level.Move3(this); }
}