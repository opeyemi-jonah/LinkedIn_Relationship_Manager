using LinkedIn_Relationship_Manager.Models;
using LinkedIn_Relationship_Manager.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkedIn_Relationship_Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userrepo;

        public UserController(IUser usr)
        {
            _userrepo = usr;
        }
        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            var users = _userrepo.GetAllUsers();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet("{id}")] //or [Route("{id}")]
        public ActionResult<List<User>> GetUserByUserId(int id)
        {
            var users = _userrepo.GetUserByUserId(id);
            if (users is null)
            {
                return NotFound("User Not Found! ");
            }
            return Ok(users);
        }

        [HttpPost]
        [Route("Creates")]
        public ActionResult Create(User user)
        {
            var usr = _userrepo.CreateUser(user);
            if (usr == null)
            {
                return BadRequest("Failed to create user");
            }

            return Ok("Create user! " + user);
        }
    }
}
