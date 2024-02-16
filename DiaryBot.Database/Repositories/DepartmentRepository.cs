using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        private ApplicationContext _context;

        public DepartmentRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(Department item)
        {
            _context.Department.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.Department.Find(id);
            _context.Department.Remove(obj);
            _context.SaveChanges();
        }

        public Department Get(int id)
        {
            var obj = _context.Department.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Department> GetList() => _context.Department.ToList();

        public void Update(Department item)
        {
            var obj = _context.Department.Find(item.Id);

            obj.DepartmentName = item.DepartmentName;

            _context.Department.Update(obj);
            _context.SaveChanges();
        }
    }
}
