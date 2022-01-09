using Newtonsoft.Json;
using okLogin.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace okLogin.Services
{
    public class ApiServices
    {
        public async Task<bool> RegisterAsync( string username, string password, string confirmPassword)
        {
            var client = new HttpClient();
            var model = new RegisterBindingModel
            {
                UserName = username,
                Password = password,
                ConfirmPassword = confirmPassword
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            var responce = await client.PostAsync("http://localhost/auth/register.php", content);
            return responce.IsSuccessStatusCode;
        }
    }
}
