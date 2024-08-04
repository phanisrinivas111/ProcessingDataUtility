namespace ProcessData.Entities
{
    public class Root
    {
        public string? DatabaseID { get; set; }
        public List<Identity>? Identities { get; set; }
        public List<string>? Labels { get; set; }
        public Display? Display { get; set; }
        public object? Symbols { get; set; }
        public object? COG { get; set; }
        public int? StorageTypeId { get; set; }
        public object? ParentId { get; set; }
        public List<Attachment>? Attachments { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
