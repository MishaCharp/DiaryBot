using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace DiaryBot.Database.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationContext _context;

        public UserRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.User.Find(id);
            _context.User.Remove(obj);
            _context.SaveChanges();
        }

        public User Get(int id)
        {
            var obj = _context.User.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<User> GetList() => _context.User.ToList();

        public void Update(User item)
        {
            var obj = _context.User.Find(item.VKID);

            obj.VKID = item.VKID;
            obj.Student = item.Student;
            obj.Login = item.Login;
            obj.Password = item.Password;

            _context.User.Update(obj);
            _context.SaveChanges();
        }
    }
}
