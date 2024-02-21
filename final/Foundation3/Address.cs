class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string address)
    {
        string[] parts = address.Split(',');
        Street = parts[0].Trim();
        City = parts[1].Trim();
        State = parts[2].Trim();
        Country = parts[3].Trim();
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}