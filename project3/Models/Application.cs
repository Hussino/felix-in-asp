using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project3.Models
{
    public class Application
    {
        [Key]
        public int app_id { get; set; }

        public int? job_id { get; set; }
        [ForeignKey("job_id")]
        public virtual job? job { get; set; }
       
        public int? user_id { get; set; }
        [ForeignKey("user_id")]
        public virtual user? user { get; set; }

        public int? company_id { get; set; }
        [ForeignKey("company_id")]
        public virtual company? company { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? date_of_app { get; set; }

        public string CV { get; set; } = null!;

    }
}
