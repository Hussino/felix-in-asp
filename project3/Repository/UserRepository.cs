using Microsoft.EntityFrameworkCore;
using project3.Data;
using project3.IRepository;
using project3.Models;

namespace project3.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly FelixDbContext _context;
        public UserRepository(FelixDbContext context)
        {
            _context = context;
        }
        
        public bool Add(user user)
        {
            _context.Add(user);
            return Save();
        }

        public bool Delete(user user)
        {
            _context.Remove(user);
            return Save();
        }

        public async Task<IEnumerable<user>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<user> GetByNameAsync(string name)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.user_name == name);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(user user)
        {
            _context.Update(user);
            return Save();
        }

        
    }
}
