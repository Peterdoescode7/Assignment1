using System.ComponentModel.DataAnnotations;
namespace EquipmentRequest.Models {
    public class UserRequest {
        [Key]
        public int ID {get; set;}
        
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter your phone number in the format XXX-XXX-XXXX")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please specify your role(Student/Professor)")]
        public string? Role { get; set; }

        [Required(ErrorMessage = "Please specify the type of equipment (Laptop/Phone/Tablet/Another)")]
        public string? EquipmentType { get; set; }

        [Required(ErrorMessage = "Please specify any details for the request")]
        public string? RequestDetails { get; set; }

        [Required(ErrorMessage = "Please enter the duration of the request")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number.")]
        public int? Duration { get; set; }
    }
}