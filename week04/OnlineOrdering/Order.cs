class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product); 
    }

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
        Console.WriteLine($"Name : {_customer.GetName()}\n");

        int item = 0;
        foreach (Product products in _products)
        {
            item += 1;
            Console.WriteLine($"{item}: {products.GetName()} {products.GetProductId()}");
        }
    }

    public void Shipping()
    {
        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.WriteLine("Address:");
        _customer.DisplayAddress();  
    }
}