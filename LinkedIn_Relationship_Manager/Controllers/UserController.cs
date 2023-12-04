using LinkedIn_Relationship_Manager.Models;
using LinkedIn_Relationship_Manager.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinkedIn_Relationship_Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userRepo;

        public UserController(IUser userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _userRepo.GetAllUsersAsync();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserByUserId(int id)
        {
            var user = await _userRepo.GetUserByUserIdAsync(id);
            if (user == null)
            {
                return NotFound("User Not Found!");
            }
            return Ok(user);
        }

        [HttpPost]
        [Route("Creates")]
        public async Task<ActionResult<string>> Create(User user)
        {
            var userId = await _userRepo.CreateUserAsync(user);
            if (userId == 0) // Assuming UserId is an integer
            {
                return BadRequest("Failed to create user");
            }

            return Ok($"User created successfully. UserId: {userId}");
        }

        [HttpPut]
        [Route("Updates")]
        public async Task<ActionResult<string>> Update(User user)
        {
            var success = await _userRepo.UpdateUserAsync(user);
            if (!success)
            {
                return BadRequest("Failed to update user");
            }

            return Ok($"User updated successfully. UserId: {user.UserId}");
        }

        [HttpDelete]
        [Route("Deletes")]
        public async Task<ActionResult<string>> Delete(User user)
        {
            var success = await _userRepo.DeleteUserAsync(user);
            if (!success)
            {
                return BadRequest("Failed to delete user");
            }

            return Ok($"User deleted successfully. UserId: {user.UserId}");
        }
    }
}
