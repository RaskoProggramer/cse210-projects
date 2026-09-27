class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }

        return false;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}\n{_state}\n{_country}");
    }
}