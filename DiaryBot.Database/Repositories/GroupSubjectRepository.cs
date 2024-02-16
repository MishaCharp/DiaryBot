using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class GroupSubjectRepository : IRepository<GroupSubject>
    {
        private ApplicationContext _context;

        public GroupSubjectRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(GroupSubject item)
        {
            _context.GroupSubject.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.GroupSubject.Find(id);
            _context.GroupSubject.Remove(obj);
            _context.SaveChanges();
        }

        public GroupSubject Get(int id)
        {
            var obj = _context.GroupSubject.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<GroupSubject> GetList() => _context.GroupSubject.ToList();

        public void Update(GroupSubject item)
        {
            var obj = _context.GroupSubject.Find(item.Id);

            obj.Group = item.Group;
            obj.Subject = item.Subject;

            _context.GroupSubject.Update(obj);
            _context.SaveChanges();
        }
    }
}
