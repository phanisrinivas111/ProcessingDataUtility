namespace ProcessData.Entities
{
    public class Identity
    {
        public string? Identifier { get; set; }
        public string? Name { get; set; }
        public bool? IsUserIdentity { get; set; }
        public int? Permission { get; set; }
    }
}
