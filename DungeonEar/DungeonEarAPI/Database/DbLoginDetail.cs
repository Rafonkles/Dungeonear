using System.ComponentModel.DataAnnotations;

namespace DungeonEarAPI.Database {
    public class DbLoginDetail {

        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }



    }
}