using project3.Models;

namespace project3.IRepository
{
    public interface IApplicationRepository
    {
        //IEnumerable<Application> GetAll(string SortProperty, SortOrder sortOrder);

        IEnumerable<Application> GetAll();

        Application GetById(int id);

        //IEnumerable<Application> SearchByName(string name);
        int delete_all(string deleteallapps);

        //Task<IEnumerable<user>> GetJobByCity(string city);

        bool Add(Application application);
        bool Update(Application application);
        bool Delete(Application application);
        bool Save();
    }
}
