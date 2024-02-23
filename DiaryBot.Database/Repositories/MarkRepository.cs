using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class MarkRepository : IRepository<Mark>
    {
        private ApplicationContext _context;

        public MarkRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Mark Create(Mark item)
        {
            _context.Mark.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.Mark.Find(id);
            if (obj != null)
            {
                _context.Mark.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public Mark Get(int id)
        {
            var obj = _context.Mark.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Mark> GetList() => _context.Mark.ToList();

        public Mark Update(Mark item)
        {
            var obj = _context.Mark.Find(item.Id);

            obj.Value = item.Value;

            _context.Mark.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
