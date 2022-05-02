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
                return null;
            }
            var result = new UserLogin();
            result.Username = dbm.Username;
            result.Id = dbm.Id;
            result.Password = dbm.Password;

            return result;
        }


        [HttpPut]
        public void Put(string username, string password) {

            TheDatabase.LoginDetails.Add(new DbLoginDetail() {
                Username = username,
                Password = password

            });
            TheDatabase.SaveChanges();


        }



    }
}
