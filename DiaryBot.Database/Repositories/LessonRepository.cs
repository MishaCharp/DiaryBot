using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class LessonRepository : IRepository<Lesson>
    {
        private ApplicationContext _context;

        public LessonRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(Lesson item)
        {
            _context.Lesson.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.Lesson.Find(id);
            _context.Lesson.Remove(obj);
            _context.SaveChanges();
        }

        public Lesson Get(int id)
        {
            var obj = _context.Lesson.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Lesson> GetList() => _context.Lesson.ToList();

        public void Update(Lesson item)
        {
            var obj = _context.Lesson.Find(item.Id);

            obj.Date = item.Date;

            _context.Lesson.Update(obj);
            _context.SaveChanges();
        }
    }
}
