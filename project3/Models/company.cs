using System.ComponentModel.DataAnnotations;

namespace project3.Models
{
    public class company
    {
        [Key]
        public int company_id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string company_name { get; set; } = null!;

        [Required(ErrorMessage ="Email is required")]
        public string? company_email { get; set; }

        [DataType(DataType.Password)]
        public string? password { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? phone { get; set; }

        public string company_image { get; set; } = null!;

        public virtual ICollection<job>? Jobs { get; set; }

    }
}
