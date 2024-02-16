using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private ApplicationContext _context;

        public GroupRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(Group item)
        {
            _context.Group.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.Group.Find(id);
            _context.Group.Remove(obj);
            _context.SaveChanges();
        }

        public Group Get(int id)
        {
            var obj = _context.Group.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Group> GetList() => _context.Group.ToList();

        public void Update(Group item)
        {
            var obj = _context.Group.Find(item.Id);

            obj.GroupName = item.GroupName;

            _context.Group.Update(obj);
            _context.SaveChanges();
        }
    }
}
