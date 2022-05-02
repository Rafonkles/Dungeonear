using DungeonEar;
using DungeonEarAPI.Database;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DungeonEarAPI.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class LoginProviderController : ControllerBase {

        public DungeonEarDatabaseContext TheDatabase { get; set; }

        public LoginProviderController(DungeonEarDatabaseContext dbc) {
            TheDatabase = dbc;
        }

        [HttpGet]
        public UserLogin Get(string username, string password) {
            var dbm = TheDatabase.LoginDetails.FirstOrDefault(login => login.Username == username && login.Password == password);
            if (dbm == null) {
                Response.StatusCode = 401;
                return null;
            }
            var result = new UserLogin();
            result.Username = dbm.Username;
            result.Id = dbm.Id;
            result.Password = dbm.Password;

            return result;
        }


        [HttpPut]
        public void Put(UserLogin userDetails) {

            TheDatabase.LoginDetails.Add(new DbLoginDetail() {
                Username = userDetails.Username,
                Password = userDetails.Password

            });
            TheDatabase.SaveChanges();


        }



    }
}
