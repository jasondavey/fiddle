namespace AddressBook
{
    internal class DomesticAddress : Address
    {
        public DomesticAddress()
        {
            Country = "UNITED STATES";
        }

        public new string Country { get; private set; }
    }
}