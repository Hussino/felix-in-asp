using project3.Models;

namespace project3.IRepository
{
    public interface ICompanyRepository
    {
        IEnumerable<company> GetAll(string SortProperty, SortOrder sortOrder);
        IEnumerable<company> GetAll();
        company GetById(int id);
        IEnumerable<company> SearchByName(string name);

        bool Add(company company);
        bool Update(company company);
        bool Delete(company company);
        bool Save();
    }
}
