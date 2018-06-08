using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows;
using Newtonsoft.Json;
using DigitalWalletClassLib;

namespace DigitialWalletClassLib
{
    public class DataAccess
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage ResponseMessage;
        public DataAccess()
        {
            client.BaseAddress = new Uri("http://localhost:64888/api/");



        }

        public async Task<List<User>>LoadUserData()
        {
            ResponseMessage = await client.GetAsync("Users");
            var Content = JsonConvert.DeserializeObject<List<User>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Account>>LoadAccountData()
        {
            ResponseMessage = await client.GetAsync("Users");
            var Content = JsonConvert.DeserializeObject<List<Account>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }
        

        
    }
}
