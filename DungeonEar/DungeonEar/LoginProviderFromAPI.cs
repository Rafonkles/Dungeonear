using System.Net.Http.Json;
using System.Text.Json;

namespace DungeonEar {
    public class LoginProviderFromAPI {

        public async Task <bool> Login(string username, string password) {





            HttpClient client = new HttpClient();


            // var locs = await client.GetFromJsonAsync<UserLogin[]>("http://localhost:5219/loginprovider");
            //     client.PutAsync("http://localhost:5219/loginprovider",)



            var userLogin = new UserLogin();
            userLogin.Username = username;
            userLogin.Password = password;


            var json = JsonContent.Create(userLogin);
            var myRequest = new HttpRequestMessage() { 
                //Content = json,
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://localhost:5219/loginprovider?username={username}&password={password}")
            };

            var resp = await client.SendAsync(myRequest);

            if (resp.StatusCode != System.Net.HttpStatusCode.OK) {
                // json = "Error";
                return false;
            }else { 
                return true; 
            }



        }
        



        public async  Task RegisterNewUser(string username, string password) {

            HttpClient client = new HttpClient();


           // var locs = await client.GetFromJsonAsync<UserLogin[]>("http://localhost:5219/loginprovider");
      //     client.PutAsync("http://localhost:5219/loginprovider",)
          


            var userLogin = new UserLogin();
            userLogin.Username = username;
            userLogin.Password = password;
           
            
            var json = JsonContent.Create(userLogin);
            var resp = await client.PutAsync("http://localhost:5219/loginprovider/", json);
                
            if (resp.StatusCode != System.Net.HttpStatusCode.OK) {
               // json = "Error";
            }
        }


    }
}
