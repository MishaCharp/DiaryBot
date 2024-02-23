using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class LessonRepository : IRepository<Lesson>
    {
        private ApplicationContext _context;

        public LessonRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Lesson Create(Lesson item)
        {
            _context.Lesson.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.Lesson.Find(id);
            if (obj != null)
            {
                _context.Lesson.Remove(obj);
                _context.SaveChanges();

                return true;
            }
            else return false;
        }

        public Lesson Get(int id)
        {
            var obj = _context.Lesson.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Lesson> GetList() => _context.Lesson.ToList();

        public Lesson Update(Lesson item)
        {
            var obj = _context.Lesson.Find(item.Id);

            obj.Date = item.Date;

            _context.Lesson.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
