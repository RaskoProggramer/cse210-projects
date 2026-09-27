using System.Net.Sockets;

class Customer
{
    private string _name;
    private Address  _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public void DisplayAddress()
    {
        _address.DisplayAddress();
    }
      public bool IsInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        return false;
    }
}