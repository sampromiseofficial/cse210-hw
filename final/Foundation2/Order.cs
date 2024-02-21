class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.GetTotalCost();
        }

        totalPrice += customer.IsInNIGERIA() ? 5 : 35; // Shipping cost
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"Name: {product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {customer.Name}\nAddress: {customer.GetAddressString()}";
    }
}