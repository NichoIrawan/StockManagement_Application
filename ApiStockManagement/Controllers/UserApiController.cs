using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using static StockManagement.Models.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIControll : ControllerBase
    {
        //Placeholder for database context -> Will be changed
        private static List<User> listUser = new List<User>()
        {
            new User("admin", "admin", Roles.Admin, "admin"),
            new User("staff", "staff", Roles.Staff, "staff"),
            new User("manager", "manager", Roles.Manager, "manager")
        };


        // GET: api/<User>
        [HttpGet]
        public IEnumerable<User> Get()
            
        {
            return listUser;
        }

        // GET api/<User>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return listUser.ElementAt(id);
        }

        // POST api/<User>
        [HttpPost]
        public void Post([FromBody]User userBaru)
        {
            listUser.Add(userBaru);
        }

        // PUT api/<User>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User userBaru)
        {
          User user = listUser.ElementAt(id);
            if (user != null) {
                return;
            }
            user.Username = userBaru.Username;
            user.Name = userBaru.Name;
            user.Role = userBaru.Role;
            user.Password = userBaru.Password;
        }

        // DELETE api/<User>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                listUser.RemoveAt(id);
            } catch(Exception e)
            {
                Console.WriteLine("Id tidak ditemukan");
            }
        }
    }
}
