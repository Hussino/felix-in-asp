using System.ComponentModel.DataAnnotations;

namespace project3.Models
{

    public class user
    {
        [Key]
        public int user_id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MinLength(3, ErrorMessage = "Name must be more than 3 letters")]
        [MaxLength(50,ErrorMessage ="Name cannot be more than 50 letters")]
        public string user_name { set; get; } = string.Empty;

        [Required(ErrorMessage = "email is required")]
        public string user_email { set; get; } = null!;

        [DataType(DataType.PhoneNumber)]
        public int? user_phone   { set; get; }

        [Required(ErrorMessage ="Age must be Entered")][MinLength(18, ErrorMessage ="You have to be +18")]
        public int user_age     { set; get; }

        [DataType(DataType.Password)]
        public string user_password { set; get; } = null!;

        [Required(ErrorMessage ="this field is required")]
        [MinLength(4,ErrorMessage ="Male or Female")]
        [MaxLength(6,ErrorMessage ="Male or Feamle")]
        public string? gender  { set; get; }

        public string user_image { set; get; } = null!;

        public int user_role { set; get; }

    }
}
