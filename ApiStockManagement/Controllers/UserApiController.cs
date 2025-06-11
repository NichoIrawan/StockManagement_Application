using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using StockManagementLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly string _filePath = "Data/ListUser.json";
        private static List<User>? _listUser;

        private readonly JsonHandler<List<User>> _jsonHandlerList = JsonHandler<List<User>>.GetInstance();

        // API to get "User" as List.
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            _listUser = _jsonHandlerList.ReadJsonFromFile(_filePath);

            return Ok(_listUser);
        }

        // API to get "User" by username.
        [HttpGet("{username}")]
        public ActionResult<User> Get(string username)
        {
            _listUser = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (_listUser == null) return NotFound();

            var user = _listUser.FirstOrDefault(u => u.username == username);

            return user != null ? Ok(user) : NotFound();
        }

        // API to add a new "User".
        [HttpPost]
        public ActionResult Post([FromBody]User userBaru)
        {
            _listUser = _jsonHandlerList.ReadJsonFromFile(_filePath);

            foreach (User user in _listUser)
            {
                if (user.username == userBaru.username)
                {
                    return BadRequest("username already exists");
                }
            }
            
            _listUser.Add(userBaru);
            _jsonHandlerList.WriteJsonToFile(_filePath, _listUser);
            return CreatedAtAction(nameof(Get), new { id = userBaru.username }, userBaru);
        }

        // API to update an existing "User" by username.
        [HttpPut("{username}")]
        public void Put(string username, [FromBody]User userBaru)
        {
            _listUser = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (_listUser == null) return;

            var user = _listUser.FirstOrDefault(u => u.username == userBaru.username);

            user.username = userBaru.username;
            user.name = userBaru.name;
            user.role = userBaru.role;
            user.password = userBaru.password;

            _jsonHandlerList.WriteJsonToFile(_filePath, _listUser);
        }

        // API to delete an existing "User" by username.
        [HttpDelete("{username}")]
        public void Delete(string username)
        {
            _listUser = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (_listUser == null) return;

            _listUser.RemoveAll(u => u.username == username);

            _jsonHandlerList.WriteJsonToFile(_filePath, _listUser);
        }
    }
}
