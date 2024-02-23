using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace DiaryBot.Database.Repositories
{
    public class VKUserRepository : IRepository<VKUser>
    {
        private ApplicationContext _context;

        public VKUserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public VKUser Create(VKUser item)
        {
            _context.VKUser.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.VKUser.Find(id);
            if (obj != null)
            {
                _context.VKUser.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public VKUser Get(int id)
        {
            var obj = _context.VKUser.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<VKUser> GetList() => _context.VKUser.ToList();

        public VKUser Update(VKUser item)
        {
            var obj = _context.VKUser.Find(item.VKID);

            obj.VKID = item.VKID;
            obj.Student = item.Student;
            obj.Login = item.Login;
            obj.Password = item.Password;

            _context.VKUser.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
