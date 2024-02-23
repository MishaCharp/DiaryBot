using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        private ApplicationContext _context;

        public DepartmentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Department Create(Department item)
        {
            _context.Department.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(int id)
        {
            var obj = _context.Department.Find(id);
            if(obj != null)
            {
                _context.Department.Remove(obj);
                _context.SaveChanges();

                return true;
            }
            else return false;
        }

        public Department Get(int id)
        {
            var obj = _context.Department.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Department> GetList() => _context.Department.ToList();

        public Department Update(Department item)
        {
            var obj = _context.Department.Find(item.Id);

            obj.DepartmentName = item.DepartmentName;

            _context.Department.Update(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}
