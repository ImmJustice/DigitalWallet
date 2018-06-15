using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows;
using Newtonsoft.Json;
using DigitalWalletApp.Models;

namespace DigitialWalletClassLib
{
    public class DataAccess
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage ResponseMessage;
        public DataAccess()
        {
            client.BaseAddress = new Uri("http://localhost:64888/api/"); // Change when post API
        }

        public async Task<List<User>>LoadUserData()
        {
            ResponseMessage = await client.GetAsync("Users/allusers");
            var Content = JsonConvert.DeserializeObject<List<User>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Account>>LoadAccountData()
        {
            ResponseMessage = await client.GetAsync("Accounts");
            var Content = JsonConvert.DeserializeObject<List<Account>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Invoice>>LoadInvoiceData()
        {
            ResponseMessage = await client.GetAsync("Invoices");
            var Content = JsonConvert.DeserializeObject<List<Invoice>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Team>> LoadTeamData()
        {
            ResponseMessage = await client.GetAsync("Teams");
            var Content = JsonConvert.DeserializeObject<List<Team>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<Transaction>>LoadTransactionData()
        {
            ResponseMessage = await client.GetAsync("Transactions");
            var Content = JsonConvert.DeserializeObject<List<Transaction>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;
        }

        public async Task<List<WorkAllocation>>LoadWorkAllocationData()
        {
            ResponseMessage = await client.GetAsync("WorkAllocations");
            var Content = JsonConvert.DeserializeObject<List<WorkAllocation>>(await ResponseMessage.Content.ReadAsStringAsync());
            return Content;

            
        }

        
    }
}
