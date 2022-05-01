using DungeonEar;
using DungeonEarAPI.Database;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DungeonEarAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class LocationProviderController : ControllerBase
    {

        public DungeonEarDatabaseContext TheDatabase { get; set; }

        public LocationProviderController(DungeonEarDatabaseContext dbc)
        {
            TheDatabase = dbc;
        }

        [HttpGet]
        public IEnumerable<Location> Get() {
            
            foreach(var nextDbLocation in TheDatabase.Locations.ToList()){
                var theLocation =  new Location(nextDbLocation.RoomNumber) {
                    Description = nextDbLocation.Description,
                    Name = nextDbLocation.Title

                };

                var roomExits = TheDatabase.Exits.Where(ex => ex.RoomNumber == nextDbLocation.RoomNumber);

                foreach (var nextExit in roomExits) {

                    theLocation.SetExit(nextExit.ExitDirection, nextExit.ExitRoomNumber);

                }
                

            yield return theLocation;

        }


    }
    }
}