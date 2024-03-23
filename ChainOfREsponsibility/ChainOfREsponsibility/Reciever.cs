namespace ChainOfREsponsibility
{
    public class Reciever
    {
        readonly string _name;

        readonly List<TransportationType> _preferedTransportation;

        public Reciever(string name, List<TransportationType> preferedTransportation)
        {
            _name = name;
            _preferedTransportation = preferedTransportation;
        }
        public string GetName() { return _name; }
        public List<TransportationType> GetPrefTrans() { return _preferedTransportation; }

        public Order MakeAnOrder(string content)
        {
            return new Order(content, _preferedTransportation);
        }        
    }
}
