using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class LessonMarkRepository : IRepository<LessonMark>
    {
        private ApplicationContext _context;

        public LessonMarkRepository(ApplicationContext context)
        {
            _context = context;
        }

        public LessonMark Create(LessonMark item)
        {
            _context.LessonMark.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.LessonMark.Find(id);
            if(obj != null) 
            {
                _context.LessonMark.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public LessonMark Get(int id)
        {
            var obj = _context.LessonMark.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<LessonMark> GetList() => _context.LessonMark.ToList();

        public LessonMark Update(LessonMark item)
        {
            var obj = _context.LessonMark.Find(item.Id);

            obj.Lesson = item.Lesson;
            obj.Mark = item.Mark;

            _context.LessonMark.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
