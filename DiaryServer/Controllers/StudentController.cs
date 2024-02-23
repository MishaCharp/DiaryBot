using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;
using DiaryServer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiaryServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase, ICRUDable<Student>
    {
        private readonly IRepository<Student> _studentRepository;


        public StudentController(IRepository<Student> studentRrepository)
        {
            _studentRepository = studentRrepository;
        }

        [HttpPost]
        public Student Create(Student obj)
        {
            return _studentRepository.Create(new Student
            {
                GroupId = obj.GroupId,
                Name = obj.Name,
                Surname = obj.Surname,
                Patronymic = obj.Patronymic
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentRepository.Delete(id);

            return Ok(200);
        }

        [HttpGet("{id}")]
        public Student Get(int id) => _studentRepository.Get(id);

        [HttpGet]
        public IEnumerable<Student> GetAll() => _studentRepository.GetList();

        [HttpPut]
        public Student Update(Student obj)
        {
            _studentRepository.Update(obj);

            return obj;
        }
    }
}
