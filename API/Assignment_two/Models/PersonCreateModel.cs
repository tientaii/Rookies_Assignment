using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment_one.Models
{
    public class PersonCreateModel
    {
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "{0} is required!!!")]
        public string? LastName { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "{0} is required!!!")]

        public string? FirstName { get; set; }

        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public string FullName
        {
            get
            {
                var FullName = LastName + " " + FirstName;
                return FullName;
            }
        }
    }
}