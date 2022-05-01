namespace DungeonEar {
    public abstract class LocationProviderBase {


        protected Dictionary<int, Location> locations = new Dictionary<int, Location>();

        public abstract Task LoadLocations(); 
            
        public async virtual Task Initialise(InitialisationOptions opt) {
        }
        

        public Location GetLocationWithId (int id) {
            return locations[id];
        }


    }
}
