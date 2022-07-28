using System.ComponentModel.DataAnnotations;
namespace ContactPage.Data
{
    public class Entry
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [MaxLength(250)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [MaxLength(250)]
        public string? FirstName { get; set; }
       
        [Required(ErrorMessage = "Phone number is required!")]
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
   
        public DateTime BirthDate { get; set; }

    }
}
