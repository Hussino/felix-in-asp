using project3.Data;
using project3.IRepository;
using project3.Models;

namespace project3.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly FelixDbContext _context;
        public MessageRepository(FelixDbContext context)
        {
            _context = context;
        }

        public bool Add(Message message)
        {
            _context.Add(message);
            return Save();
        }

        public bool Delete(Message message)
        {
            _context.Remove(message);
            return Save();
        }

        public IEnumerable<Message> GetAll()
        {
            List<Message> messages = _context.Messages.ToList();
            return messages;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
