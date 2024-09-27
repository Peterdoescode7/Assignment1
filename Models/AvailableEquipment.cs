using System.ComponentModel.DataAnnotations;
namespace EquipmentRequest.Models {
    public class AvailableEquipment {
        [Key]
        public int EquipmentID {get; set;}

        public string? Type { get; set; }

        public string? Description { get; set; }

        public string? Availability { get; set; }
    }
}