using project3.Models;

namespace project3.ViewModels
{
    public class CompanyViewModel
    {
        public IEnumerable<job> jobs { set; get; }
        public IEnumerable<Application> applications { set; get; }

    }
}
