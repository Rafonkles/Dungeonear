using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonEar {
    public class LocationProvider {

        public Dictionary<Direction, int> Exits { get; set; }

        public Location GetLocationWithId (int id) {
            var result = new Location(id);
            result.Name = "John"+id.ToString();
            result.Description = $"John is cool{id}";
            return result;
        }


    }
}
