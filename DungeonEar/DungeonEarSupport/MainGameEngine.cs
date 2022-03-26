using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonEar {
    public class MainGameEngine {

        public LocationProvider world { get; set; }

        public int CurrentLocationId { get; set; }

        public MainGameEngine(LocationProvider lp) {

            world = lp;
            CurrentLocationId = 0;
            world.LoadLocations();

        }
    
        public Location GetCurrentLocation() {
            return world.GetLocationWithId(CurrentLocationId);
        }


    
    
    }
}
