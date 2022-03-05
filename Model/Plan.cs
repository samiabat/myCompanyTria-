namespace InspectionAPI.Model
{
    public class Plan{
        public int Id{ get; set; }
        public string Name{ get; set; } = string.Empty;
        public DateTime Start{ get; set; }
        public DateTime End{ get; set; }

    }
}