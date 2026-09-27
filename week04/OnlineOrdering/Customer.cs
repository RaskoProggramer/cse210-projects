using System.Net.Sockets;

class Customer
{
    private string _name;
    private List<Address>  _address = new List<Address>();

    public Customer(string name, List<Address> address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA(Address address)
    {
        return address.IsInUSA();
    }
}