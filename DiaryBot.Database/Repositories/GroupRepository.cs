using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private ApplicationContext _context;

        public GroupRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Group Create(Group item)
        {
            _context.Group.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.Group.Find(id);
            if (obj != null)
            {
                _context.Group.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public Group Get(int id)
        {
            var obj = _context.Group.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Group> GetList() => _context.Group.ToList();

        public Group Update(Group item)
        {
            var obj = _context.Group.Find(item.Id);

            obj.GroupName = item.GroupName;

            _context.Group.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
