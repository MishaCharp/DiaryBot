using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class GroupSubjectRepository : IRepository<GroupSubject>
    {
        private ApplicationContext _context;

        public GroupSubjectRepository(ApplicationContext context)
        {
            _context = context;
        }

        public GroupSubject Create(GroupSubject item)
        {
            _context.GroupSubject.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.GroupSubject.Find(id);
            if(obj != null)
            {
                _context.GroupSubject.Remove(obj);
                _context.SaveChanges();

                return true;
            }
            else return false;
        }

        public GroupSubject Get(int id)
        {
            var obj = _context.GroupSubject.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<GroupSubject> GetList() => _context.GroupSubject.ToList();

        public GroupSubject Update(GroupSubject item)
        {
            var obj = _context.GroupSubject.Find(item.Id);

            obj.Group = item.Group;
            obj.Subject = item.Subject;

            _context.GroupSubject.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
