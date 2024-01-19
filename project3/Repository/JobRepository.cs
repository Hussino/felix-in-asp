using Microsoft.EntityFrameworkCore;
using project3.Data;
using project3.IRepository;
using project3.Models;

namespace project3.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly FelixDbContext _context;
        public JobRepository(FelixDbContext context)
        {
            _context = context;
        }

        public bool Add(job job)
        {
            _context.Add(job);
            return Save();
        }

        public bool Delete(job job)
        {
            _context.Remove(job);
            return Save();
        }

        

        public int add_job(string addjob)
        {
            int count = _context.Database.ExecuteSqlRaw(addjob);
            return count;
        }

        public IEnumerable<job> GetAll(string SortProperty, SortOrder sortOrder)
        {
            List<job> jobs = _context.Jobs.ToList();
            if (SortProperty.ToLower() == "job_name")
            {
                if(sortOrder == SortOrder.Ascending)
                    jobs = jobs.OrderBy(n =>n.job_name).ToList();
                else
                    jobs = jobs.OrderByDescending(n => n.job_name).ToList();
            }
            else if (SortProperty.ToLower() == "job_id")
            {
                if (sortOrder == SortOrder.Ascending)
                    jobs = jobs.OrderBy(d => d.job_id).ToList();
                else
                    jobs = jobs.OrderByDescending(d => d.job_id).ToList();
            }
            else if (SortProperty.ToLower() == "city")
            {
                if (sortOrder == SortOrder.Ascending)
                    jobs = jobs.OrderBy(c => c.city).ToList();
                else
                    jobs = jobs.OrderByDescending(c => c.city).ToList();
            }

            return jobs;
        }

        public IEnumerable<job> GetAll()
        {
            List<job> jobs = _context.Jobs.ToList();
            return jobs;
        }

        public job GetById(int id)
        {
            return _context.Jobs.FirstOrDefault(j => j.job_id == id);
        }

        public IEnumerable<job> SearchByName(string name)
        {
            return  _context.Jobs.Where(j => j.job_name.Contains(name)).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(job job)
        {
            _context.Update(job);
            return Save();
        }
    }
}
