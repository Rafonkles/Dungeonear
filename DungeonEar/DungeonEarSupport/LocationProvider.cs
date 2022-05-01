namespace DungeonEar {
    public class LocationProviderHardCoded : LocationProviderBase {



        public override Task LoadLocations() {
            var l = CreateLocation(0, "The Cave", "Cave Description");
            l.Exits.Add(Direction.North, 1);
            locations.Add(0,l );

            l = CreateLocation(1, "The Lower Dungeon", "Ld Description");
            l.Exits.Add(Direction.North, 2);
            l.Exits.Add(Direction.West, 3);
            l.Exits.Add(Direction.South, 0);
            locations.Add(1,l);


            l =  CreateLocation(2, "The Iron Chambers", "IC Description");
            l.Exits.Add(Direction.North, 7);
            l.Exits.Add(Direction.East, 8);
            l.Exits.Add(Direction.West, 6);
            l.Exits.Add(Direction.South, 1);
            locations.Add(2, l);



            l = CreateLocation(3, "Dungeon Enterance", "DE Description");
            l.Exits.Add(Direction.North, 6);
            l.Exits.Add(Direction.East, 1);
            l.Exits.Add(Direction.West, 3);
            locations.Add(3, l);


            l =  CreateLocation(4, "The Arena", "Arena Description");
            l.Exits.Add(Direction.North, 5);
            l.Exits.Add(Direction.East, 3);
            locations.Add(4, l);


            l =  CreateLocation(5, "The Chapel", "Chapel Description");
            l.Exits.Add(Direction.South, 4);
            locations.Add(5, l);



            l =  CreateLocation(6, "The Guard Room", "GR Description");
            l.Exits.Add(Direction.East, 2);
            l.Exits.Add(Direction.South, 3);
            locations.Add(6, l);


            l =  CreateLocation(7, "The Cellar", "Cellar Description");
            l.Exits.Add(Direction.South, 2);
            locations.Add(7, l);



            l =  CreateLocation(8, "The Decaying Lair", "DL Description");
            l.Exits.Add(Direction.East, 9);
            l.Exits.Add(Direction.West, 2);
            locations.Add(8, l);


            l =  CreateLocation(9, "The Wardens Layer", "WL Description");
            l.Exits.Add(Direction.West, 8);
            locations.Add(9, l);

            return Task.CompletedTask;

        }

        private Location CreateLocation(int id, string name, string description ){
            var result = new Location(id);
            result.Name = name;
            result.Description = description;

            
            return result;
        }


       

    }
}
