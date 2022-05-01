using System.ComponentModel.DataAnnotations;
using DungeonEar;

namespace DungeonEarAPI.Database {
    public class DbExits {

       [Key]
        public int Id { get; set; }
        public int RoomNumber { get; set; }

        public int ExitRoomNumber { get; set; }

        public Direction ExitDirection { get; set; }



    }
}