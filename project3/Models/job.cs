using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project3.Models
{
    public enum SortOrder { Ascending=0, Descending=1}
    public class job
    {
        [Key]
        public int job_id { get; set; }

        [Required(ErrorMessage ="Name of Job is Required")]
        public string? job_name { get; set;}

        public string? age_range     { get; set; }

        public string job_age { get; set; } = null!;

        public int? experience_years { get; set; }

        public string? city { get; set; }

        public int work_hours   { get; set; }

        public string? job_image { get; set; }


        public int? company_id { get; set; }
        [ForeignKey("company_id")]
        public virtual company? company { get; set; }
    }
}
