namespace project3.Models
{
    public class Category
    {
        public int cat_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        
        public ICollection<job> jobs { get; set; }
    }
}
