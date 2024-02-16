using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class SubjectRepository : IRepository<Subject>
    {
        private ApplicationContext _context;

        public SubjectRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(Subject item)
        {
            _context.Subject.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.Subject.Find(id);
            _context.Subject.Remove(obj);
            _context.SaveChanges();
        }

        public Subject Get(int id)
        {
            var obj = _context.Subject.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Subject> GetList() => _context.Subject.ToList();

        public void Update(Subject item)
        {
            var obj = _context.Subject.Find(item.Id);

            obj.SubjectName = item.SubjectName;

            _context.Subject.Update(obj);
            _context.SaveChanges();
        }
    }
}
