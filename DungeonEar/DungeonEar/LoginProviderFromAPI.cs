using System.Text.Json;

namespace DungeonEar {
    public class LoginProviderFromAPI {



        public async  Task RegisterNewUser() {

            HttpClient client = new HttpClient();


           // var locs = await client.GetFromJsonAsync<UserLogin[]>("http://localhost:5219/loginprovider");
      //     client.PutAsync("http://localhost:5219/loginprovider",)
          


            var userLogin = new UserLogin();
            userLogin.Username = "Hardcoded";
            userLogin.Password = "Hardcoded";
           
            
            var json = JsonSerializer.Serialize(userLogin);

            var resp = await client.PutAsync("http://localhost:5219/loginprovider/", new StringContent(json));
                
            if (resp.StatusCode != System.Net.HttpStatusCode.OK) {
                json = "Error";
            }
        }


    }
}
