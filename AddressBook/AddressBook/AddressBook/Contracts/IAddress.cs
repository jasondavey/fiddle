namespace AddressBook
{
    public interface IAddress
    {
        string StreetOne { get; set; }
        string StreetTwo { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Country { get; set; }
    }
}