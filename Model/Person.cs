using System.ComponentModel.DataAnnotations;

namespace InspectionAPI.Model
{
    public class Person{
        public enum Role{ 
            CompanyManager, BranchManager, Employee
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public string username { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;

        [Range(1000, 100000)]
        public int Salary { get; set; }
    }
}
