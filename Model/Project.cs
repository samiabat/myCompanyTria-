using System.ComponentModel.DataAnnotations;

namespace InspectionAPI.Model
{
    public class Project{
        public Guid Id{ get; set; }
        [Required]
        public string ProjectName{ get; set; } = string.Empty;
        [Required]
        public DateTime StartDate{ get; set; }
        [Required]
        public DateTime EndDate{ get; set; }
        public string NameOfManager { get; set; } = string.Empty;
    }
}