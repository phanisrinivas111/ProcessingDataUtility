namespace ProcessData.Entities
{
    public class Multistate
    {
        public bool IsDigitalSet { get; set; }
        public List<string> StateVariables { get; set; }
        public List<object> ErrorStateValues { get; set; }
        public int LowerValue { get; set; }
        public List<State> States { get; set; }
        public List<string> DefaultStateValues { get; set; }
    }
}
