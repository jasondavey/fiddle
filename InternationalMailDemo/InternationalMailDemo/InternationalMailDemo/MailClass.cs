namespace InternationalMailDemo
{
    internal class MailClass
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public Address FromAddress { get; set; }
        public Address ToAddress { get; set; }
        public string[] Services { get; set; }
    }
}