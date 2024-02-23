using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class SubjectRepository : IRepository<Subject>
    {
        private ApplicationContext _context;

        public SubjectRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Subject Create(Subject item)
        {
            _context.Subject.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.Subject.Find(id);
            if (obj != null)
            {
                _context.Subject.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public Subject Get(int id)
        {
            var obj = _context.Subject.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Subject> GetList() => _context.Subject.ToList();

        public Subject Update(Subject item)
        {
            var obj = _context.Subject.Find(item.Id);

            obj.SubjectName = item.SubjectName;

            _context.Subject.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
