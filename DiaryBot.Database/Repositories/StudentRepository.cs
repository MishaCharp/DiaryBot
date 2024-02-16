using DiaryBot.Database;
using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;

namespace iaryBot.Database.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private ApplicationContext _context;

        public StudentRepository()
        {
            _context = ApplicationContext.Instance;
        }

        public void Create(Student item)
        {
            _context.Student.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _context.Student.Find(id);
            _context.Student.Remove(obj);
            _context.SaveChanges();
        }

        public Student Get(int id)
        {
            var obj = _context.Student.Find(id);
            if (obj == null) return null;
            else return obj;
        }

        public List<Student> GetList() => _context.Student.ToList();

        public void Update(Student item)
        {
            var obj = _context.Student.Find(item.Id);

            obj.Surname = item.Surname;
            obj.Name = item.Name;
            obj.Patronymic = item.Patronymic;

            _context.Student.Update(obj);
            _context.SaveChanges();
        }
    }
}
