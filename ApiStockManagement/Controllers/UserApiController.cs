using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using StockManagementLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIControll : ControllerBase
    {
        private string filePath = "Data/ListUser.json";
        private static List<User>? listUser;

        // GET: api/<User>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            listUser = JsonHandler<List<User>>.readJsonFromFile(filePath);

            return Ok(listUser);
        }

        // GET api/<User>/5
        [HttpGet("{username}")]
        public ActionResult<User> Get(string username)
        {
            listUser = JsonHandler<List<User>>.readJsonFromFile(filePath);

            if (listUser == null) return NotFound();

            var user = listUser.FirstOrDefault(u => u.username == username);

            return user != null ? Ok(user) : NotFound();
        }

        // POST api/<User>
        [HttpPost]
        public ActionResult Post([FromBody]User userBaru)
        {
            listUser = JsonHandler<List<User>>.readJsonFromFile(filePath);

            foreach (User user in listUser)
            {
                if (user.username == userBaru.username)
                {
                    return BadRequest("username already exists");
                }
            }
            
            listUser.Add(userBaru);
            JsonHandler<List<User>>.writeJsonToFile(filePath, listUser);
            return CreatedAtAction(nameof(Get), new { id = userBaru.username }, userBaru);
        }

        // PUT api/<User>/5
        [HttpPut("{username}")]
        public void Put(string username, [FromBody]User userBaru)
        {
            listUser = JsonHandler<List<User>>.readJsonFromFile(filePath);

            if (listUser == null) return;

            var user = listUser.FirstOrDefault(u => u.username == userBaru.username);

            user.username = userBaru.username;
            user.name = userBaru.name;
            user.role = userBaru.role;
            user.password = userBaru.password;

            JsonHandler<List<User>>.writeJsonToFile(filePath, listUser);
        }

        // DELETE api/<User>/5
        [HttpDelete("{username}")]
        public void Delete(string username)
        {
            listUser = JsonHandler<List<User>>.readJsonFromFile(filePath);

            if (listUser == null) return;

            listUser.RemoveAll(u => u.username == username);

            JsonHandler<List<User>>.writeJsonToFile(filePath, listUser);
        }
    }
}
