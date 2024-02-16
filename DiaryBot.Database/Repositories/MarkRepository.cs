using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class MarkRepository : IRepository<Mark>
    {
        private ApplicationContext _context;

        public MarkRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(Mark item)
        {
            _context.Mark.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.Mark.Find(id);
            _context.Mark.Remove(obj);
            _context.SaveChanges();
        }

        public Mark Get(int id)
        {
            var obj = _context.Mark.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Mark> GetList() => _context.Mark.ToList();

        public void Update(Mark item)
        {
            var obj = _context.Mark.Find(item.Id);

            obj.Value = item.Value;

            _context.Mark.Update(obj);
            _context.SaveChanges();
        }
    }
}
