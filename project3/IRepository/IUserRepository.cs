using project3.Models;

namespace project3.IRepository
{
    public interface IUserRepository
    {

        Task<IEnumerable<user>> GetAll();
        //Task<user> GetByIdAsync(int id);
        Task<user> GetByNameAsync(string name);

        bool Add(user user);
        bool Update(user user);
        bool Delete(user user);
        bool Save();


    }
}
