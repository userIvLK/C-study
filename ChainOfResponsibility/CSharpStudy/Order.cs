namespace ChainOfREsponsibility
{
   
    public class Order
    {
        readonly string _content;
        readonly List<TransportationType> _preferedTransportation;
        public Order(string content, List<TransportationType> preferedTransportation)
        {
            _content = content;
            _preferedTransportation= preferedTransportation;
        }
        public string GetContent()
        {
            return _content;
        }
        public List<TransportationType> GetTransportPrefs()
        {
            return _preferedTransportation;
        }
    }

}
