using project3.Models;

namespace project3.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<job> job { get; set; }
        public IEnumerable<company> company { get; set; }
        public IEnumerable<Application> applications { get; set; }
    }
}
