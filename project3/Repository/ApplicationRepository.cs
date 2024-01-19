using Microsoft.EntityFrameworkCore;
using project3.Data;
using project3.IRepository;
using project3.Models;

namespace project3.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly FelixDbContext _context;
        public ApplicationRepository(FelixDbContext context)
        {
            _context = context;
        }

        public bool Add(Application application)
        {
            _context.Add(application);
            return Save();
        }

        public bool Delete(Application application)
        {
            _context.Remove(application);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
        public bool Update(Application application)
        {
            _context.Update(application);
            return Save();
        }

        public Application GetById(int id)
        {
            return _context.Applications.FirstOrDefault(a => a.app_id == id);
        }

        public int delete_all(string deleteallapps)
        {
            int count = _context.Database.ExecuteSqlRaw(deleteallapps);
            return count;
        }

        public IEnumerable<Application> GetAll()
        {
            List<Application> applications = _context.Applications.ToList();
            return applications;
        }
    }
}
