using System.ComponentModel.DataAnnotations;

namespace MachinePark.Shared.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage = "Location is required")]
        [StringLength(25, ErrorMessage = "Location is too long")]
        public string Location { get; set; }
        public DateTime Edited { get; set; }
        public bool Status { get; set; }
    }
}
