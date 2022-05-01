using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DungeonEar {
    public class LocationProviderFromAPI : LocationProviderBase {



        public async override Task LoadLocations() {

            HttpClient client = new HttpClient();

            locations.Clear();

            var locs = await client.GetFromJsonAsync<Location[]>("http://localhost:5219/locationprovider");

            foreach (var location in locs) {
                locations.Add(location.Id, location);
            }


        }



    }
}
