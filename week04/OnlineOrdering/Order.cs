class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public float Total()
{
    float total = 0;

    foreach (Product product in _products)
    {
        total += product.Total();
    }

    if (_customer.IsInUSA())
    {
        total += 5;
    }
    else
    {
        total += 35;
    }

    return total;
    }

    public void Packaging()
    {
        Console.WriteLine($"Name : {_customer._name}\n");

        int item = 0;
        foreach (Product products in _products)
        {
            item += 1;
            Console.WriteLine($"{item}: {product.GetName()} {Product.GetProductId()} {product.GetQuantity()} {product}")
        }
    }
}