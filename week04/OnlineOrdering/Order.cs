            if (address.IsInUSA(address.GetAddress()))
class Order
{
    private List<Customer> _customer = new List<Customer>();
    private List<Product> _products = new List<Product>();

    public float GetTotalCost()
{
    float total = 0;

    foreach (Product product in _products)
    {
        total += product.Total();
    }

    foreach (Customer address in _customer)
        {
            if (_customer.IsInUSA())
        }
    return total;
    }
}