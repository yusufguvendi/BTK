using System.ComponentModel.DataAnnotations;
//
namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-Mail is required.")]
        public String? EMail {get; set;} = String.Empty;

        [Required(ErrorMessage = "First Name is required.")]
        public String? FirstName {get; set;} = String.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        public String? LastName {get; set;} = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age {get; set;}
        public DateTime ApplyAt {get; set;}
        [Required(ErrorMessage = "Course must be selected.")]
        public String? SelectedCourse {get; set;} = String.Empty;

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }


    
    }
}