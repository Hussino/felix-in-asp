using project3.Models;

namespace project3.IRepository
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetAll();
        bool Save();
        bool Delete(Message message);
        bool Add(Message message);
    }
}
