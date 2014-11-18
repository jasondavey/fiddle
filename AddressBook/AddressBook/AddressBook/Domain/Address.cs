namespace AddressBook
{
    internal class Address : IAddress
    {
        public string StreetOne { get; set; }
        public string StreetTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }
}