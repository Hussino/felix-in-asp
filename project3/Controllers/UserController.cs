using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using project3.Data;
using project3.IRepository;
using project3.Models;
using project3.ViewModels;

namespace project3.Controllers
{
    public class UserController : Controller
    {
        private readonly IJobRepository _jobRepository;
        private readonly IUserRepository _userRepository;
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMessageRepository _messageRepository;

        public UserController(IJobRepository jobRepository, IUserRepository userRepository, IApplicationRepository applicationRepository, IMessageRepository messageRepository)
        {
            _jobRepository = jobRepository;
            _userRepository = userRepository;
            _applicationRepository = applicationRepository;
            _messageRepository = messageRepository;
            
        }

        public async Task<IActionResult> Index()
        {
            CompanyViewModel companyViewModel = new CompanyViewModel();
            companyViewModel.applications = _applicationRepository.GetAll();
            companyViewModel.jobs = _jobRepository.GetAll();


            return View(companyViewModel);
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult contact(Message message)
        {
                _messageRepository.Add(message);
                return RedirectToAction("contact");

        }
        public IActionResult privacy()
        {
            return View();
        }
        public async Task<IActionResult> UserDetails(string name)
        {
            user user = await _userRepository.GetByNameAsync(name);
            return View(user);
        }
        public IActionResult user_login()
        {
            return View();
        }
        public IActionResult user_register()
        {
            return View();
        }
        public IActionResult JobDetails(int id)
        {
            ApplicationViewModel viewModel = new ApplicationViewModel();
            var job = _jobRepository.GetById(id);
            viewModel.job = job;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> JobDetails(CreateApplicationModelView applicationViewModel, IFormFile CV)
        {
            var newFileName = "";
            if (CV != null)
            {
                newFileName = Convert.ToString(Guid.NewGuid().ToString());
                var concatFileName = String.Concat(newFileName, ".pdf");
                var filePath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "CvPDF")).Root + $@"\{concatFileName}";

                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    await CV.CopyToAsync(fs);
                    fs.Flush();
                }
            }

            ModelState["CV"].ValidationState = ModelValidationState.Valid;

            if (ModelState.IsValid)
            {
                var application = new Application
                {
                    job_id = applicationViewModel.job_id,
                    user_id = applicationViewModel.user_id,
                    company_id = applicationViewModel.company_id,
                    date_of_app = applicationViewModel.date_of_app,
                    CV = String.Concat(newFileName, "pdf")
                };
                _applicationRepository.Add(application);
                return RedirectToAction("Index");
            }
            var errors = ViewData.ModelState.Where(n => n.Value.Errors.Count > 0).ToList();

            return RedirectToAction("JobDetails");
        }
    }
}
