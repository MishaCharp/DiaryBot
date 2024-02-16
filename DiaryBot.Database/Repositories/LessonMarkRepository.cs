using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class LessonMarkRepository : IRepository<LessonMark>
    {
        private ApplicationContext _context;

        public LessonMarkRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(LessonMark item)
        {
            _context.LessonMark.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.LessonMark.Find(id);
            _context.LessonMark.Remove(obj);
            _context.SaveChanges();
        }

        public LessonMark Get(int id)
        {
            var obj = _context.LessonMark.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<LessonMark> GetList() => _context.LessonMark.ToList();

        public void Update(LessonMark item)
        {
            var obj = _context.LessonMark.Find(item.Id);

            obj.Lesson = item.Lesson;
            obj.Mark = item.Mark;

            _context.LessonMark.Update(obj);
            _context.SaveChanges();
        }
    }
}
