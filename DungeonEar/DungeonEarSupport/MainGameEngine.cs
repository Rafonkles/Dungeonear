using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonEar {
    public class MainGameEngine {

        public LocationProviderBase World { get; set; }

        public int CurrentLocationId { get; set; }

        public MainGameEngine(LocationProviderBase lp) {

            World = lp;
            CurrentLocationId = 0;
            World.LoadLocations();

        }

        public async Task Initialise(InitialisationOptions opts) {
            await World.Initialise(opts);
            await World.LoadLocations();
        }
    
        public Location GetCurrentLocation() {
            return World.GetLocationWithId(CurrentLocationId);
        }


    
    
    }
}
