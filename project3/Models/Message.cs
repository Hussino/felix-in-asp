using System.ComponentModel.DataAnnotations;

namespace project3.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; } = null!;
        public string email { get; set; } = null!;
        public string theMessage { get; set; } = null!;
    }
}
