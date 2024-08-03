namespace ProcessingDataUtility.Entities
{
    public class Display
    {
        public List<Symbol>? Symbols { get; set; }
        public List<object>? AttachmentIds { get; set; }
        public object? RequestId { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public object? LegacyDisplay { get; set; }
        public object? EventFramePath { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public object? Path { get; set; }
        public string? Owner { get; set; }
        public bool ReadOnly { get; set; }
        public int Revision { get; set; }
        public DisplayProperties? DisplayProperties { get; set; }
        public string? ProductVersion { get; set; }
    }
}
