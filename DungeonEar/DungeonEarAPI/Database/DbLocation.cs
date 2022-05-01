using System.ComponentModel.DataAnnotations;

namespace DungeonEarAPI.Database {
    public class DbLocation {

        [Key]
        public int Id { get; set; }
       
        public int RoomNumber { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }



    }
}