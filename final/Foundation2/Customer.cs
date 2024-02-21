class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInNIGERIA()
    {
        return address.IsInNIGERIA();
    }

    public string Name { get { return name; } }

    public string GetAddressString()
    {
        return address.ToString();
    }
}