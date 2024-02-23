using DiaryBot.Database.Models;
using DiaryBot.Database.Repositories.Base;
using DiaryServer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiaryServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VKUserController : ControllerBase, ICRUDable<VKUser>
    {
        private readonly IRepository<VKUser> _userVKRepository;


        public VKUserController(IRepository<VKUser> userRrepository)
        {
            _userVKRepository = userRrepository;
        }

        [HttpPost]
        public VKUser Create(VKUser obj)
        {
            _userVKRepository.Create(obj);

            return obj;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userVKRepository.Delete(id);

            return Ok(200);
        }

        [HttpGet("{id}")]
        public VKUser Get(int id) => _userVKRepository.Get(id);

        [Authorize]
        [HttpGet]
        public IEnumerable<VKUser> GetAll() => _userVKRepository.GetList();

        [HttpPut]
        public VKUser Update(VKUser user)
        {
            _userVKRepository.Update(user);

            return user;
        }

    }
}
