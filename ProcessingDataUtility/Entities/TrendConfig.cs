namespace ProcessingDataUtility.Entities
{
    public class TrendConfig
    {
        public ValueScale valueScale { get; set; }
        public TimeScale timeScale { get; set; }
        public int padding { get; set; }
        public bool nowPosition { get; set; }
        public int LegendWidth { get; set; }
    }
}
