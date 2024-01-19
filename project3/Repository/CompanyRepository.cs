using Microsoft.EntityFrameworkCore;
using project3.Data;
using project3.IRepository;
using project3.Models;

namespace project3.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly FelixDbContext _context;
        public CompanyRepository(FelixDbContext context)
        {
            _context = context;
        }

        public bool Add(company company)
        {
            _context.Add(company);
            return Save();
        }

        public bool Delete(company company)
        {
            _context.Remove(company);
            return Save();
        }

        public  IEnumerable<company> GetAll()
        {
            List<company> companies =  _context.Companies.ToList();
            return companies;
        }

        public IEnumerable<company> GetAll(string SortProperty, SortOrder sortOrder)
        {
            List<company> companies = _context.Companies.ToList();
            if (SortProperty.ToLower() == "job_name")
            {
                if (sortOrder == SortOrder.Ascending)
                    companies = companies.OrderBy(n => n.company_name).ToList();
                else
                    companies = companies.OrderByDescending(n => n.company_name).ToList();
            }
            else if (SortProperty.ToLower() == "job_id")
            {
                if (sortOrder == SortOrder.Ascending)
                    companies = companies.OrderBy(d => d.company_id).ToList();
                else
                    companies = companies.OrderByDescending(d => d.company_id).ToList();
            }
            

            return companies;
        }


        public company GetById(int id)
        {
            return  _context.Companies.FirstOrDefault(c => c.company_id == id);
        }

        public IEnumerable<company> SearchByName(string name)
        {
            return _context.Companies.Where(c => c.company_name.Contains(name)).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(company company)
        {
            _context.Update(company);
            return Save();
        }
    }
}
