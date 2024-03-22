namespace ChainOfREsponsibility
{
    public abstract class AbstractHandler
    {
        abstract public void Handle(List<TransportationType> tps);
        public AbstractHandler? Successor { get; set; }

    }
}
