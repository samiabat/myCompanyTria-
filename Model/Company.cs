using System.ComponentModel.DataAnnotations;

namespace InspectionAPI.Model
{
    public class Company{
        [Required]
        public Guid Id{ get; set; }
        [Required]
        public string CompanyName { get; set; } = string.Empty;

        public int NoOfWorkers{ get; set;}
    }
}