namespace ProcessingDataUtility.Entities
{
    public class Symbol
    {
        public string? Name { get; set; }
        public string? SymbolType { get; set; }
        public Configuration? Configuration { get; set; }
        public List<string>? DataSources { get; set; }
        public List<string>? MSDataSources { get; set; }
        public List<List<object>>? MSLimitDataSources { get; set; }
        public List<string>? MSSymbolsIds { get; set; }
    }
}
