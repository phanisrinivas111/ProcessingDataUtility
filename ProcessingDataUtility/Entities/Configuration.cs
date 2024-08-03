namespace ProcessingDataUtility.Entities
{
    public class Configuration
    {
        public int AttachmentId { get; set; }
        public double Width { get; set; }
        public int Height { get; set; }
        public int Rotation { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public string? Fill { get; set; }
        public string? Stroke { get; set; }
        public int? StrokeWidth { get; set; }
        public string? StrokeStyle { get; set; }
        public string? DataShape { get; set; }
        public string? ValueStroke { get; set; }
        public bool? ShowTime { get; set; }
        public string? IndicatorFillUp { get; set; }
        public string? IndicatorFillDown { get; set; }
        public string? IndicatorFillNeutral { get; set; }
        public bool? ShowDifferential { get; set; }
        public string? DifferentialType { get; set; }
        public bool? ShowIndicator { get; set; }
        public bool? ShowValue { get; set; }
        public bool? ShowTarget { get; set; }
        public bool? ShowLabel { get; set; }
        public bool? ShowUOM { get; set; }
        public string? TextAlignment { get; set; }
        public string? FontName { get; set; }
        public int? FontSize { get; set; }
        public bool? UseIntegerFontSize { get; set; }
        public string? NameType { get; set; }
        public bool? updateDisplay { get; set; }
        public bool? SetTextFromLink { get; set; }
        public string? StaticText { get; set; }
        public string? LinkURL { get; set; }
        public bool? NewTab { get; set; }
        public List<Multistate>? Multistates { get; set; }
        public TrendConfig? TrendConfig { get; set; }
        public bool? MultipleScales { get; set; }
        public ValueScaleSetting? ValueScaleSetting { get; set; }
        public int? TimeScaleType { get; set; }
        public bool? NowPosition { get; set; }
        public object? TraceSettings { get; set; }
        public bool? CursorDragValues { get; set; }
        public List<string>? Columns { get; set; }
        public List<string>? ColumnWidths { get; set; }
        public ColumnWrap? ColumnWrap { get; set; }
        public string? Style { get; set; }
    }
}
