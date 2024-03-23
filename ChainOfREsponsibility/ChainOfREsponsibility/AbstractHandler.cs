namespace ChainOfREsponsibility
{
    public abstract class AbstractHandler
    {
        abstract public void Handle(Order order);
        public AbstractHandler? Successor { get; set; }

    }
}
