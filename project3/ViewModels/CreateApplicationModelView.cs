namespace project3.ViewModels
{
    public class CreateApplicationModelView
    {
        public int app_id { get; set; }

        public int? job_id { get; set;}

        public int? user_id { get; set;}

        public int? company_id { get; set;}

        public DateTime? date_of_app { get; set; }

        public string CV { get; set; }


    }
}
